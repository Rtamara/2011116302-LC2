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
    public class TrabajadorsApiController : ApiController
    {
        private _2011116302DbContext db = new _2011116302DbContext();

        // GET: api/TrabajadorsApi
        public IQueryable<Trabajador> GetTrabajadors()
        {
            return db.Trabajadors;
        }

        // GET: api/TrabajadorsApi/5
        [ResponseType(typeof(Trabajador))]
        public IHttpActionResult GetTrabajador(int id)
        {
            Trabajador trabajador = db.Trabajadors.Find(id);
            if (trabajador == null)
            {
                return NotFound();
            }

            return Ok(trabajador);
        }

        // PUT: api/TrabajadorsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTrabajador(int id, Trabajador trabajador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != trabajador.TrabajadorId)
            {
                return BadRequest();
            }

            db.Entry(trabajador).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrabajadorExists(id))
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

        // POST: api/TrabajadorsApi
        [ResponseType(typeof(Trabajador))]
        public IHttpActionResult PostTrabajador(Trabajador trabajador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Trabajadors.Add(trabajador);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = trabajador.TrabajadorId }, trabajador);
        }

        // DELETE: api/TrabajadorsApi/5
        [ResponseType(typeof(Trabajador))]
        public IHttpActionResult DeleteTrabajador(int id)
        {
            Trabajador trabajador = db.Trabajadors.Find(id);
            if (trabajador == null)
            {
                return NotFound();
            }

            db.Trabajadors.Remove(trabajador);
            db.SaveChanges();

            return Ok(trabajador);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TrabajadorExists(int id)
        {
            return db.Trabajadors.Count(e => e.TrabajadorId == id) > 0;
        }
    }
}