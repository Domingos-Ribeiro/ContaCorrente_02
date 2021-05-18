using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContaCorrente_02.DAL;
using ContaCorrente_02.RR;

namespace ContaCorrente_02.Controllers
{
    public class RR2Controller : Controller
    {
        private RRClass obj = new RRClass();
        // GET: RR2Controller
        public ActionResult Index()
        {

            obj.RecolonizarTabelaClientes();
            obj.RecolonizarTabelaMovimentos();
            return View();
        }
    }

}