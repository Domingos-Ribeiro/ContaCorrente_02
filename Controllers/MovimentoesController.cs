using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContaCorrente_02.DAL;
using ContaCorrente_02.Models;

namespace ContaCorrente_02.Controllers
{
    public class MovimentoesController : Controller
    {
        private ContaCorrente_02Context db = new ContaCorrente_02Context();

        // GET: Movimentoes
        public ActionResult Index()
        {
            var movimentos = db.Movimentos.Include(m => m.Cliente);
            return View(movimentos.ToList());
        }

        // GET: Movimentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimento movimento = db.Movimentos.Find(id);
            if (movimento == null)
            {
                return HttpNotFound();
            }
            return View(movimento);
        }

        // GET: Movimentoes/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "NomeCliente");
            return View();
        }

        // POST: Movimentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DataRegisto,Descricao,ValorDebito,ValorCredito,ClienteId")] Movimento movimento)
        {
            if (ModelState.IsValid)
            {
                db.Movimentos.Add(movimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "NomeCliente", movimento.ClienteId);
            return View(movimento);
        }

        // GET: Movimentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimento movimento = db.Movimentos.Find(id);
            if (movimento == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "NomeCliente", movimento.ClienteId);
            return View(movimento);
        }

        // POST: Movimentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DataRegisto,Descricao,ValorDebito,ValorCredito,ClienteId")] Movimento movimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "NomeCliente", movimento.ClienteId);
            return View(movimento);
        }

        // GET: Movimentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movimento movimento = db.Movimentos.Find(id);
            if (movimento == null)
            {
                return HttpNotFound();
            }
            return View(movimento);
        }

        // POST: Movimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movimento movimento = db.Movimentos.Find(id);
            db.Movimentos.Remove(movimento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
