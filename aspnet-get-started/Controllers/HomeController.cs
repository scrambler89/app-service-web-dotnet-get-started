using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var json = "{\"id\": \"7\",\"email\": \"michael.lawson@reqres.in\",\"first_name\": \"Michael\",\"last_name\": \"Lawson\",
            \"avatar\": \"https://reqres.in/img/faces/7-image.jpg\"}"
            JSONModel.Rootobject records = JsonConvert.DeserializeObject<JSONModel.Rootobject>(json); 
            return View(records);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }
    }
}