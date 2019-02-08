using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Exico.HangFire.Common;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using TestWebClientServer.Models;
using Newtonsoft.Json;
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
            Options.TaskId = 1;
            Options.UserId = "0000000000000000000000000000000000000000000000000000000";            
            Options.SetOption("Person", new Temp()
            {
                age = 100,
                Name = "ishtiaque"
            });
           // Console.WriteLine(Options.GetOption<Temp>("Person").Name);
            JobManager j = new JobManager();
            j.CreateFireAndForgetJob(Options, BJobClient);            
            return View();
        }
      
    }

}
