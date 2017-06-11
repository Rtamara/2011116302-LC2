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
    public class VentasApiController : ApiController
    {
        private _2011116302DbContext db = new _2011116302DbContext();

        // GET: api/VentasApi
        public IQueryable<Venta> GetVentas()
        {
            return db.Ventas;
        }

        // GET: api/VentasApi/5
        [ResponseType(typeof(Venta))]
        public IHttpActionResult GetVenta(int id)
        {
            Venta venta = db.Ventas.Find(id);
            if (venta == null)
            {
                return NotFound();
            }

            return Ok(venta);
        }

        // PUT: api/VentasApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVenta(int id, Venta venta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != venta.VentaId)
            {
                return BadRequest();
            }

            db.Entry(venta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(id))
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

        // POST: api/VentasApi
        [ResponseType(typeof(Venta))]
        public IHttpActionResult PostVenta(Venta venta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ventas.Add(venta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = venta.VentaId }, venta);
        }

        // DELETE: api/VentasApi/5
        [ResponseType(typeof(Venta))]
        public IHttpActionResult DeleteVenta(int id)
        {
            Venta venta = db.Ventas.Find(id);
            if (venta == null)
            {
                return NotFound();
            }

            db.Ventas.Remove(venta);
            db.SaveChanges();

            return Ok(venta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VentaExists(int id)
        {
            return db.Ventas.Count(e => e.VentaId == id) > 0;
        }
    }
}