using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace GuidGenerate
{
    public class GetGuid
    {
        private readonly ILogger _logger;

        public GetGuid(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<GetGuid>();
        }

        [Function("GetGuid")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            _logger.LogInformation("Started the GetGuid Fuction Call");

            var request = new StreamReader(req.Body).ReadToEnd();
            var query = System.Web.HttpUtility.UrlEncode(req.Url.Query);

            Dictionary<string, StringValues> parsedQueryString = QueryHelpers.ParseNullableQuery(req.Url.Query);

            string? numberOfGuidsText = parsedQueryString["count"];

            int numberOfGuids = 1;

            List<string> guids = new List<string>();


            if (numberOfGuidsText is not null && int.TryParse(numberOfGuidsText, out numberOfGuids))
            {
                _logger.LogInformation($"Number of Guids requested: {numberOfGuids}");
            }
            else
            {
                _logger.LogInformation($"Unknow number of Guids requested use 1");
                numberOfGuids = 1;
            }

            for ( int i = 0; i < numberOfGuids; i++)
            {
                guids.Add(Guid.NewGuid().ToString());
            }


            var response = req.CreateResponse(HttpStatusCode.OK);
            
            //response.Headers.Add("Content-Type", "text/pain; charset=utf-8");
            //response.WriteString("Hello World");

            await response.WriteAsJsonAsync(guids);

            return response;
        }
    }
}
