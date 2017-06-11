﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2011116302_ENT.Entityes;
using _2011116302_PER;

namespace LineaTelefonica.WebAPI.Controllers
{
    public class ProvinciasApiController : ApiController
    {
        private _2011116302DbContext db = new _2011116302DbContext();

        // GET: api/ProvinciasApi
        public IQueryable<Provincia> GetProvincias()
        {
            return db.Provincias;
        }

        // GET: api/ProvinciasApi/5
        [ResponseType(typeof(Provincia))]
        public IHttpActionResult GetProvincia(int id)
        {
            Provincia provincia = db.Provincias.Find(id);
            if (provincia == null)
            {
                return NotFound();
            }

            return Ok(provincia);
        }

        // PUT: api/ProvinciasApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProvincia(int id, Provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != provincia.ProvinciaId)
            {
                return BadRequest();
            }

            db.Entry(provincia).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinciaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProvinciasApi
        [ResponseType(typeof(Provincia))]
        public IHttpActionResult PostProvincia(Provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Provincias.Add(provincia);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = provincia.ProvinciaId }, provincia);
        }

        // DELETE: api/ProvinciasApi/5
        [ResponseType(typeof(Provincia))]
        public IHttpActionResult DeleteProvincia(int id)
        {
            Provincia provincia = db.Provincias.Find(id);
            if (provincia == null)
            {
                return NotFound();
            }

            db.Provincias.Remove(provincia);
            db.SaveChanges();

            return Ok(provincia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProvinciaExists(int id)
        {
            return db.Provincias.Count(e => e.ProvinciaId == id) > 0;
        }
    }
}