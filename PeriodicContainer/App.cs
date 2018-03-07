using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PeriodicContainer.Models;
using PeriodicContainer.Services;

namespace PeriodicContainer
{
    public class App
    {
        private readonly ITestService _testService;
        private readonly ILogger<App> _logger;
        private readonly AppSettings _config;

        public App(ITestService testService,
            IOptions<AppSettings> config,
            ILogger<App> logger)
        {
            _testService = testService;
            _logger = logger;
            _config = config.Value;
        }

        public void Run()
        {            
            //_logger.LogInformation($"This is a console application for {_config.ConsoleTitle}");
            _testService.Run();                
        }
    }
}