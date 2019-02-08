using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Exico.HangFire.Common;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using TestWebClientServer.Models;

namespace TestWebClientServer.Controllers
{
    public class HomeController : Controller
    {
        public IFireAndForgetOptions Options { get; }
        public IBackgroundJobClient BJobClient { get; }

        public HomeController(IBackgroundJobClient client,IFireAndForgetOptions options)
        {
            this.Options = options;
            this.BJobClient = client;
        }
        public IActionResult Index()
        {
            return Content("Hellow");
        }

        public IActionResult Create()
        {
            JobManager j = new JobManager();
            Options.JobType = JobType.FireAndForget;
            Options.UserId = "115555444477788";
            return Content("Task Created");
        }
    }
}
