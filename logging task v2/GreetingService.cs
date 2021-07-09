using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logging_task_v2
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> log;
        private readonly IConfiguration _config;

        public GreetingService(ILogger<GreetingService> log, IConfiguration config)
        {
            this.log = log;
            _config = config;
        }

        public void Run()
        {

        }
    }
}
