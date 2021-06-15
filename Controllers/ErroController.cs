using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContaCorrente_02.Controllers
{
    public class ErroController : Controller
    {
        // GET: Erro
        // Ao chamar a view escolher o que deve aparecer para o uyilizador
        public ActionResult Index()
        {
            return View();
        }
    }
}