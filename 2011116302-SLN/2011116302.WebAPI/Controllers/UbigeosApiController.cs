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
    public class UbigeosApiController : ApiController
    {
        private _2011116302DbContext db = new _2011116302DbContext();

        // GET: api/UbigeosApi
        public IQueryable<Ubigeo> GetUbigeos()
        {
            return db.Ubigeos;
        }

        // GET: api/UbigeosApi/5
        [ResponseType(typeof(Ubigeo))]
        public IHttpActionResult GetUbigeo(int id)
        {
            Ubigeo ubigeo = db.Ubigeos.Find(id);
            if (ubigeo == null)
            {
                return NotFound();
            }

            return Ok(ubigeo);
        }

        // PUT: api/UbigeosApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUbigeo(int id, Ubigeo ubigeo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ubigeo.UbigeoId)
            {
                return BadRequest();
            }

            db.Entry(ubigeo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UbigeoExists(id))
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

        // POST: api/UbigeosApi
        [ResponseType(typeof(Ubigeo))]
        public IHttpActionResult PostUbigeo(Ubigeo ubigeo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ubigeos.Add(ubigeo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ubigeo.UbigeoId }, ubigeo);
        }

        // DELETE: api/UbigeosApi/5
        [ResponseType(typeof(Ubigeo))]
        public IHttpActionResult DeleteUbigeo(int id)
        {
            Ubigeo ubigeo = db.Ubigeos.Find(id);
            if (ubigeo == null)
            {
                return NotFound();
            }

            db.Ubigeos.Remove(ubigeo);
            db.SaveChanges();

            return Ok(ubigeo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UbigeoExists(int id)
        {
            return db.Ubigeos.Count(e => e.UbigeoId == id) > 0;
        }
    }
}