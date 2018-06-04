using System;
using System.IO;
using Microsoft.Azure.WebJobs;

namespace Samples.WebJobs.Core
{
    public class SampleScheduledWebJob
    {
        private readonly IUsefulRepository _usefulRepository;

        public SampleScheduledWebJob(IUsefulRepository usefulRepository)
        {
            _usefulRepository = usefulRepository;
        }
        
        public void DoSomethingUseful([TimerTrigger("* * * * * *", RunOnStartup = true)] TimerInfo timerInfo, TextWriter log)
        {
            // Act on the DI-ed class:
            string thing = _usefulRepository.GetFoo();
            Console.WriteLine($"{DateTime.Now} - {thing}");
        }
    }
}