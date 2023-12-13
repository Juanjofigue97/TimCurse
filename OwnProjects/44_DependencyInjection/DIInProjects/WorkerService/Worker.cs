using DIDemoLibrary;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IMessages _messages;

        public Worker(ILogger<Worker> logger, IMessages messages)
        {
            _logger = logger;
            _messages = messages;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    _logger.LogError(_messages.SayHello());
                    _logger.LogError(_messages.SayGoodbye());
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
