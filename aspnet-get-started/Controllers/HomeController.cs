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
            public class Datum
                {
                    public int id { get; set; }
                    public string email { get; set; }
                    public string first_name { get; set; }
                    public string last_name { get; set; }
                    public string avatar { get; set; }
                }
            public class Root
                {
                    public int page { get; set; }
                    public int per_page { get; set; }
                    public int total { get; set; }
                    public int total_pages { get; set; }
                    public List<Datum> data { get; set; }
                    public Support support { get; set; }
                }
            public class Support
                {
                    public string url { get; set; }
                    public string text { get; set; }
                }
            return View();
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