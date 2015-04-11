using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using myRegistrationSite.Models;
using Newtonsoft.Json;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Razor;
using Microsoft.AspNet.Mvc.Routing;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Http.Extensions;
using Microsoft.AspNet.Http.Core;
using Microsoft.AspNet.Http.Headers;
using Microsoft.AspNet.Http.Interfaces;
using Microsoft.AspNet.Http.Security;
using Microsoft.AspNet.Server;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Hosting.Server;

namespace myRegistrationSite.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {

        private string GetAttendeesDirPath()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data");
            var attendeesDirPath = Path.Combine(path, "Attendees");
            if (Directory.Exists(attendeesDirPath) == false) Directory.CreateDirectory(attendeesDirPath);
            return attendeesDirPath;
        }

        public ActionResult Index()
        {
            var attendeesDirPath = GetAttendeesDirPath();
            var attendees = Directory.GetFiles(attendeesDirPath, "*.json")
                .Select(path => System.IO.File.ReadAllText(path))
                .Select(json => JsonConvert.DeserializeObject<Attendee>(json))
                .OrderBy(attendee => attendee.CreateAt);

            return View(attendees);
        }

        [HttpPost]
        public ActionResult ClearAll()
        {
            var attendeesDirPath = GetAttendeesDirPath();
            Directory.GetFiles(attendeesDirPath, "*.json")
                .ToList()
                .ForEach(path => System.IO.File.Delete(path));

            return RedirectToAction("Index");
        }
    }
}