﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using ProyectoFinal_Anthony_Santana.DAL;
using ProyectFinal_Anthony_Santana.Models;

namespace ProyectFinal_Anthony_Santana.Controllers
{
    public class FacturasDetallesController : Controller
    {
        private RegistroDb db = new RegistroDb();

        // GET: FacturasDetalles
        public ActionResult Index()
        {
            return View(db.facturaDetalledb.ToList());
        }

        // GET: FacturasDetalles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturasDetalles facturasDetalles = db.facturaDetalledb.Find(id);
            if (facturasDetalles == null)
            {
                return HttpNotFound();
            }
            return View(facturasDetalles);
        }

        // GET: FacturasDetalles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacturasDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FacturaId,PeliculaId,Titulo,Cantidad,Precio")] FacturasDetalles facturasDetalles)
        {
            if (ModelState.IsValid)
            {
                db.facturaDetalledb.Add(facturasDetalles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facturasDetalles);
        }

        // GET: FacturasDetalles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturasDetalles facturasDetalles = db.facturaDetalledb.Find(id);
            if (facturasDetalles == null)
            {
                return HttpNotFound();
            }
            return View(facturasDetalles);
        }

        // POST: FacturasDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FacturaId,PeliculaId,Titulo,Cantidad,Precio")] FacturasDetalles facturasDetalles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facturasDetalles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facturasDetalles);
        }

        // GET: FacturasDetalles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturasDetalles facturasDetalles = db.facturaDetalledb.Find(id);
            if (facturasDetalles == null)
            {
                return HttpNotFound();
            }
            return View(facturasDetalles);
        }

        // POST: FacturasDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacturasDetalles facturasDetalles = db.facturaDetalledb.Find(id);
            db.facturaDetalledb.Remove(facturasDetalles);
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
