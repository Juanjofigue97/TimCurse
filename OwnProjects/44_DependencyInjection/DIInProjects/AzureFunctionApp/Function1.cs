using System.Collections.Generic;
using System.Net;
using DIDemoLibraryAzure;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionApp
{
    public class Function1
    {
        private readonly ILogger _logger;
        private readonly IMessages _messages;

        public Function1(ILoggerFactory loggerFactory,IMessages messages)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
            _messages = messages;
        }

        [Function("Function1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");
            response.WriteString($"{_messages.SayHello()}");
            response.WriteString($"{_messages.SayGoodbye()}");

            return response;
        }
    }
}
