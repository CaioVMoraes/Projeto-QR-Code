using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeiraProfissões.Controllers.Feira
{
    public class FeiraController : Controller
    {
        public ActionResult Index()
        {
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
    }
}