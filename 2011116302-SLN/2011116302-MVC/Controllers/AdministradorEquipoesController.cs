﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2011116302_ENT.Entityes;
using _2011116302_PER;
using _2011116302_ENT.IRepositories;

namespace _2011116302_MVC.Controllers
{
    public class AdministradorEquipoesController : Controller
    {
        private readonly IUnityOfWork _UnityOfWork;
        public AdministradorEquipoesController()
        {

        }

        public AdministradorEquipoesController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }
        // GET: AdministradorEquipoes
        public ActionResult Index()
        {
            // var administradorEquipos = _UnityOfWork.AdministradorEquipos.Include(a => a.EquipoCelulars);
            // return View(administradorEquipos.ToList());
            return View(_UnityOfWork.AdministradorEquipos.GetAll());
        }

        // GET: AdministradorEquipoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipos.Get(id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministradorEquipoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdministradorEquipoId,Modalidad,Fecha,StockDisponible")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.AdministradorEquipos.Add(administradorEquipo);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administradorEquipo);
        }

        // GET: AdministradorEquipoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipos.Get(id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            // ViewBag.EquipoCelularId = new SelectList(db.EquipoCelulars, "EquipoCelularId", "marcaEquipo", administradorEquipo.EquipoCelularId);
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdministradorEquipoId,Modalidad,Fecha,StockDisponible")] AdministradorEquipo administradorEquipo)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(administradorEquipo);
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administradorEquipo);
        }

        // GET: AdministradorEquipoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipos.Get(id);
            if (administradorEquipo == null)
            {
                return HttpNotFound();
            }
            return View(administradorEquipo);
        }

        // POST: AdministradorEquipoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdministradorEquipo administradorEquipo = _UnityOfWork.AdministradorEquipos.Get(id);
            // db.AdministradorEquipos.Remove(administradorEquipo);
            _UnityOfWork.AdministradorEquipos.Delete(administradorEquipo);
            _UnityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
