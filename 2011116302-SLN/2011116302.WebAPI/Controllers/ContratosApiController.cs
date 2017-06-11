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
    public class ContratosApiController : ApiController
    {
        private _2011116302DbContext db = new _2011116302DbContext();

        // GET: api/ContratosApi
        public IQueryable<Contrato> GetContratos()
        {
            return db.Contratos;
        }

        // GET: api/ContratosApi/5
        [ResponseType(typeof(Contrato))]
        public IHttpActionResult GetContrato(int id)
        {
            Contrato contrato = db.Contratos.Find(id);
            if (contrato == null)
            {
                return NotFound();
            }

            return Ok(contrato);
        }

        // PUT: api/ContratosApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContrato(int id, Contrato contrato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != contrato.ContratoId)
            {
                return BadRequest();
            }

            db.Entry(contrato).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContratoExists(id))
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

        // POST: api/ContratosApi
        [ResponseType(typeof(Contrato))]
        public IHttpActionResult PostContrato(Contrato contrato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Contratos.Add(contrato);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = contrato.ContratoId }, contrato);
        }

        // DELETE: api/ContratosApi/5
        [ResponseType(typeof(Contrato))]
        public IHttpActionResult DeleteContrato(int id)
        {
            Contrato contrato = db.Contratos.Find(id);
            if (contrato == null)
            {
                return NotFound();
            }

            db.Contratos.Remove(contrato);
            db.SaveChanges();

            return Ok(contrato);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContratoExists(int id)
        {
            return db.Contratos.Count(e => e.ContratoId == id) > 0;
        }
    }
}