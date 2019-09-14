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
        public ActionResult Avaliacao(int estrela)
        {
            Business.FeiraBusiness business = new Business.FeiraBusiness();

            Models.tb_avaliacao avaliacao = new Models.tb_avaliacao();
            avaliacao.qt_estrelas = estrela;

            business.Inserir(avaliacao);
            ViewData["mensagem"] = "Obrigado pela avaliação!";

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