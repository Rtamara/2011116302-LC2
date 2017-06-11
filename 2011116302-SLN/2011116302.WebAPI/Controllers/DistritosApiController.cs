using System;
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
    public class DistritosApiController : ApiController
    {
        private _2011116302DbContext db = new _2011116302DbContext();

        // GET: api/DistritosApi
        public IQueryable<Distrito> GetDistritos()
        {
            return db.Distritos;
        }

        // GET: api/DistritosApi/5
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult GetDistrito(int id)
        {
            Distrito distrito = db.Distritos.Find(id);
            if (distrito == null)
            {
                return NotFound();
            }

            return Ok(distrito);
        }

        // PUT: api/DistritosApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDistrito(int id, Distrito distrito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != distrito.DistritoId)
            {
                return BadRequest();
            }

            db.Entry(distrito).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistritoExists(id))
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

        // POST: api/DistritosApi
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult PostDistrito(Distrito distrito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Distritos.Add(distrito);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = distrito.DistritoId }, distrito);
        }

        // DELETE: api/DistritosApi/5
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult DeleteDistrito(int id)
        {
            Distrito distrito = db.Distritos.Find(id);
            if (distrito == null)
            {
                return NotFound();
            }

            db.Distritos.Remove(distrito);
            db.SaveChanges();

            return Ok(distrito);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DistritoExists(int id)
        {
            return db.Distritos.Count(e => e.DistritoId == id) > 0;
        }
    }
}