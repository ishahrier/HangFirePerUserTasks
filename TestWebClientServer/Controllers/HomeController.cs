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
        public IFireAndForgetTaskOptions Options { get; }
        public IBackgroundJobClient BJobClient { get; }

        public HomeController(IBackgroundJobClient client,IFireAndForgetTaskOptions options)
        {
            this.Options = options;
            this.BJobClient = client;
        }
        public IActionResult Index()
        {
            Options.UserId = "1";
            Options.SetOption("name", "ishtiaque");
            BJobClient.Enqueue<IFireAndForgetTask>(x=>x.Run(Options.ToJson(),JobCancellationToken.Null));
            return View();
        }
      
    }

}
