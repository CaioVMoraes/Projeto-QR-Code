using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeiraProfissões.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Avaliacao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Avaliacao(Models.tb_avaliacao avaliacao)
        {
            Business.FeiraBusiness business = new Business.FeiraBusiness();
            business.Inserir(avaliacao);

            return View();
        }
        public ActionResult SegundoAndar()
        {
            return View();
        }
        public ActionResult PrimeiroAndar()
        {
            return View();
        }
        public ActionResult Terreo()
        {
            return View();
        }
    }
}