using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PeriodicContainer.Models;

namespace PeriodicContainer.Services
{
    public interface ITestService
    {
        void Run();
    }

    public class TestService : ITestService
    {
        private readonly ILogger<TestService> _logger;
        private readonly AppSettings _config;

        public TestService(ILogger<TestService> logger,
            IOptions<AppSettings> config)
        {
            _logger = logger;
            _config = config.Value;
        }

        public void Run()
        {
            string aspNetCoreEnv = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            string netCoreEnv = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
            string connatixEnv = Environment.GetEnvironmentVariable("connatix:environment");
            Console.WriteLine($"ASPNETCORE_ENVIRONMENT is '{aspNetCoreEnv}'");
            Console.WriteLine($"NETCORE_ENVIRONMENT is '{netCoreEnv}'");
            Console.WriteLine($"connatix:environment is '{connatixEnv}'");                                           
        }
    }
}