using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SendMensageApp
{
    public class SendRest
    {
        public void Send()
        {
            var response = "";
            var error = "";
            try
            {
                //Se fija la URL sobre la que enviar la petici´on POST
                var httpWebRequest = (HttpWebRequest)WebRequest.
                Create("https://www.altiria.net:8443/apirest/ws/sendSms");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                //Establecemos el TimeOut para obtener la respuesta del servidor
                httpWebRequest.Timeout = 60000;
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"credentials\":{" + "\"login\":\"juanjo.figue97@gmail.com\",\"passwd\":\"xvy89qsf\"},";
                    //Descomentar para utilizar la autentificaci´on mediante apikey
                    //string json = "{\"credentials\":{"+ "\"apiKey\":\"YY\",\"apiSecret\":\"ZZ\"},";
                    json += " \"destination\":[\"3216972161\"],";
                    //No es posible utilizar el remitente en Am´erica pero si en Espa~na y Europa
                    //Descomentar la linea solo si se cuenta con un remitente autorizado por Altiria
                    //json += " \"message\": {\"msg\":\"Mensaje de prueba\","
                    // + "\"senderId\":\"remitente\"}}";
                    json += " \"message\": {\"msg\":\"Mensaje de prueba Cofinal \"}}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        response = streamReader.ReadToEnd();
                    };
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ConnectFailure)
                    error = "Error en la conexi´on";
                else if (e.Status == WebExceptionStatus.Timeout)
                    error = "Error TimeOut";
                else
                    error = e.Message;
            }
            finally
            {
                if (error != "")
                    Console.WriteLine(error);
                else
                    Console.WriteLine(response);
            }
        }
    }
}
