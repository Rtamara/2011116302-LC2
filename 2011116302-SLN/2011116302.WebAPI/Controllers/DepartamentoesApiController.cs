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
    public class DepartamentoesApiController : ApiController
    {
        private _2011116302DbContext db = new _2011116302DbContext();

        // GET: api/DepartamentoesApi
        public IQueryable<Departamento> GetDepartamentos()
        {
            return db.Departamentos;
        }

        // GET: api/DepartamentoesApi/5
        [ResponseType(typeof(Departamento))]
        public IHttpActionResult GetDepartamento(int id)
        {
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
            {
                return NotFound();
            }

            return Ok(departamento);
        }

        // PUT: api/DepartamentoesApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDepartamento(int id, Departamento departamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != departamento.DepartamentoId)
            {
                return BadRequest();
            }

            db.Entry(departamento).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartamentoExists(id))
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

        // POST: api/DepartamentoesApi
        [ResponseType(typeof(Departamento))]
        public IHttpActionResult PostDepartamento(Departamento departamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Departamentos.Add(departamento);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = departamento.DepartamentoId }, departamento);
        }

        // DELETE: api/DepartamentoesApi/5
        [ResponseType(typeof(Departamento))]
        public IHttpActionResult DeleteDepartamento(int id)
        {
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
            {
                return NotFound();
            }

            db.Departamentos.Remove(departamento);
            db.SaveChanges();

            return Ok(departamento);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DepartamentoExists(int id)
        {
            return db.Departamentos.Count(e => e.DepartamentoId == id) > 0;
        }
    }
}