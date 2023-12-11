using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Web;

namespace AuthorizationFormDemo.Services
{
    public class SendSMS : ISendSMS
    {
        public (bool status, int code) Send(string celular)
        {
            // Generar Codigo
            Random random = new Random();
            int output = random.Next(100000, 1000000);

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


            postData.Add(new KeyValuePair<string, string>("dest", $"57{celular}"));
            //postData.Add(new KeyValuePair<string, string>("dest", "346yyyyyyyy"));

            postData.Add(new KeyValuePair<string, string>("msg", $"Tu codigo es: {output}"));

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
            return (true, output);
        }

        public (bool status, int code) SendTest(string celular)
        {
            Random random = new Random();
            int output = random.Next(100000, 1000000);
            Console.WriteLine(output);
            return (true, output);
        }

        public (bool status, int code) SendEmail(string EmailDestino)
        {
            Random random = new Random();
            int output = random.Next(100000, 1000000);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("sistemascofinal@gmail.com", "aadxnyctwwnchyef");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            string body = $"Tu codigo es:{ output }";
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("sistemascofinal@gmail.com", "Codigo de Seguridad");
            mail.To.Add(new MailAddress(EmailDestino));
            mail.Subject = "Codigo de Seguridad";
            mail.IsBodyHtml = true;
            mail.Body = body;
            smtp.Send(mail);
            smtp.Dispose();

            return (true, output);
        }
    }
}
