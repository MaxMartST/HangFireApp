using Hangfire;
using HangFireDemo.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFireApp.Controllers
{
    [Route("/Api/HangFire")]
    public class HangFireController : Controller
    {
        private IDemoService _demoSorvice;
        private int tasksCounter;
        public HangFireController(IDemoService demoSorvice)
        {
            this._demoSorvice = demoSorvice;
        }

        [HttpGet]
        public IActionResult Index()
        {
            RecurringJob.AddOrUpdate("demo-jod", () => this._demoSorvice.RunDemoTask(), Cron.Minutely);

            return Ok();
        }
    }
}
