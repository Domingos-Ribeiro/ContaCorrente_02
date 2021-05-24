using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContaCorrente_02.Controllers
{
    public class SoParaMembrosController : Controller
    {
        // GET: SoParaMembros
        public ActionResult Index()
        {
            // Se nao há autenticação através da variável de sessão "AuthState",
            // então, direciona para a página de erro.
            string estado;
            try
            {
                estado = Session["AuthState"].ToString();

            }
            catch (Exception)
            {
                estado = "";
            }

            // Se há autenticação e o utilizador é o admin, pode aceder.

            if (estado == "Autiticated")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Erro");
            }
        }
    }
}