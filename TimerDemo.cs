using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DemoFunc
{
    public class TimerDemo
    {
        private readonly ILogger _logger;

        public TimerDemo(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<TimerDemo>();
        }

        [Function("TimerDemo")]
        public void Run([TimerTrigger("%TimerSchedule%")] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
