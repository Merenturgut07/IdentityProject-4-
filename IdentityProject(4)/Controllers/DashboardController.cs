using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace IdentityProject_4_.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            //Hava Durumu Apisi
            string api = "79dbc22f9cfe41e1db0958e0eef87f8e";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=%C4%B0stanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v1 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
