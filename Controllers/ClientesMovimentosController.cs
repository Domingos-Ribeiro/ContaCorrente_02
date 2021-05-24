using System;
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
        private ContaCorrente_02Context db = new ContaCorrente_02Context();
        public ActionResult Index(int? IdDrop)
        {


            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            //Possibilitar o envio dos movimentos
            //var vm = new ClienteMovimento();

            //vm.Movimentos = db.Movimentos.ToList();

            //ViewBag.CLIENTES = new SelectList(db.Clientes.ToList(), "Id", "NomeCliente");


            //return View(vm);
            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx



            //List<Cliente> listaClientes = db.Clientes.ToList();
            //SelectList SL = new SelectList(listaClientes, "Id", "NomeCliente");
            //ViewBag.LISTA = SL;

            //var clientes = db.Clientes.Where(c => c.Id == IdDrop);

            //return View(clientes.ToList());

            //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            ContaCorrente_02Context db = new ContaCorrente_02Context(); //estanciar a class context, apontador para a base de dados

      
                var vm = new ClienteMovimento();


                ViewBag.CLIENTES = new SelectList(db.Clientes.ToList(), "Id", "NomeCliente");

             vm.Movimentos = db.Movimentos.Where(m => m.ClienteId == IdDrop);
           

            return View(vm);
            }

    }
}