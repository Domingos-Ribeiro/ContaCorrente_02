﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContaCorrente_02.DAL;
using ContaCorrente_02.Controllers;
using ContaCorrente_02.RR;
using ContaCorrente_02.Models;
using ContaCorrente_02.ViewModel;


namespace ContaCorrente_02.Controllers
{
    public class ClientesMovimentosController : Controller
    {
        ContaCorrente_02Context db = new ContaCorrente_02Context();
        public ActionResult Index(int? IdDrop)
        {
            // Possibilitar o envio dos movimentos
            var vm = new ClienteMovimento();
            vm.Movimentos = db.Movimentos.ToList();

            ViewBag.CLIENTES = new SelectList(db.Clientes.ToList(), "Id", "NomeCliente");


            return View(vm);
        }

    }
}