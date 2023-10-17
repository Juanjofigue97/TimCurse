using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SendMensageApp;

public class SendSMS
{
    public void Send()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://www.altiria.net:8443");
        //Establecemos el TimeOut para obtener la respuesta del servidor
        client.Timeout = TimeSpan.FromSeconds(60);
        //Se compone el mensaje a enviar

        // YY y ZZ se corresponden con los valores de identificacion del usuario en el sistema.
        var postData = new List<KeyValuePair<string, string>>();

        postData.Add(new KeyValuePair<string, string>("cmd", "sendsms"));
        //postData.Add(new KeyValuePair<string, string>("login", "juanjo.figue97@gmail.com"));
        //postData.Add(new KeyValuePair<string, string>("passwd", "xvy89qsf"));
        //Descomentar para utilizar la autentificaci´on mediante apikey

        postData.Add(new KeyValuePair<string, string>("apikey", "mz7YWR4avK"));
        postData.Add(new KeyValuePair<string, string>("apisecret", "6sy655vb7n"));


        postData.Add(new KeyValuePair<string, string>("dest", "573216972161"));
        //postData.Add(new KeyValuePair<string, string>("dest", "346yyyyyyyy"));

        postData.Add(new KeyValuePair<string, string>("msg", "Mensaje de prueba Cofinal"));

        //No es posible utilizar el remitente en Am´erica pero s´ı en Espa~na y Europa
        //Descomentar la l´ınea solo si se cuenta con un remitente autorizado por Altiria
        //postData.Add(new KeyValuePair<string, string>("senderId", "remitente"));

        HttpContent content = new FormUrlEncodedContent(postData);

        String err = "";
        String resp = "";
        try
        {
            //Se fija la URL sobre la que enviar la petici´on POST
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/api/http");
            request.Content = content;
            content.Headers.ContentType.CharSet = "UTF-8";
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
            HttpResponseMessage response = client.SendAsync(request).Result;
            var responseString = response.Content.ReadAsStringAsync();
            resp = responseString.Result;
        }
        catch (Exception e)
        {
            err = e.Message;
        }
        finally
        {
            if (err != "")
                Console.WriteLine(err);
            else
                Console.WriteLine(resp);
        }

    }
}
