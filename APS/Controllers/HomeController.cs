using APS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult ClimaAgora()
        {
            return View();
        }

        public ActionResult Outros()
        {
            return View();
        }

        public JsonResult GetWeather()
        {
            Weather weath = new Weather();
            return Json(weath.getWeatherForcast(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetNoticia()
        {
            IBGE noticia = new IBGE();
            return Json(noticia.getNoticia(), JsonRequestBehavior.AllowGet);
        }

    }
}