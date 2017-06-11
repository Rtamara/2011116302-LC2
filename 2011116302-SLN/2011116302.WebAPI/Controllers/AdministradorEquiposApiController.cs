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
using _2011116302_ENT.IRepositories;
using _2011116302_ENT.EntityesDTO;
using AutoMapper;
using System.Web.Http.ModelBinding;

namespace LineaTelefonica.WebAPI.Controllers
{
    public class AdministradorEquiposApiController : ApiController
    {
        //private _2011116302DbContext db = new _2011116302DbContext();

        private readonly IUnityOfWork _UnityOfWork;

        public AdministradorEquiposApiController()
        {

        }

        public AdministradorEquiposApiController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }
        // GET: api/AdministradorEquiposApi
        //public IQueryable<AdministradorEquipo> GetAdministradorEquipos()
        }

    // GET: api/AdministradorEquiposApi/5
    [HttpGet]
    public IHttpActionResult Get()
    {
        //La capa de persistencia no debe ser modificada, porque es única para todo canal de atencion de la aplicacion
        //por lo tanto, a nivel de controlador se debe de hacer las modificaciones.
        var AdministradorEquipos = _UnityOfWork.AdministradorEquipos.GetAll();

        if (AdministradorEquipos == null)
            throw new HttpResponseException(HttpStatusCode.NotFound);

        var AdministradorEquiposDTO = new List<AdministradorEquipoDTO>();

        foreach (var administradorEquipos in AdministradorEquipos)
            AdministradorEquiposDTO.Add(Mapper.Map<AdministradorEquipo, AdministradorEquipoDTO>(administradorEquipo));

        return Ok(AdministradorEquiposDTO);
    }

    // GET: api/GenresApi/5
    //[ResponseType(typeof(Genre))]
    //public IHttpActionResult GetGenre(int id)
    //{
    //	Genre genre = db.Genres.Find(id);
    //	if (genre == null)
    //	{
    //		return NotFound();
    //	}

    //	return Ok(genre);
    //}

    // GET api/<controller>/5
    [HttpGet]
    public IHttpActionResult Get(int id)
    {
        var administradorEquipo = _UnityOfWork.AdministradorEquipos.Get(id);

        if (administradorEquipo == null)
            return NotFound();

        return Ok(Mapper.Map<AdministradorEquipo, AdministradorEquipoDTO>(administradorEquipo));
    }

    // PUT: api/GenresApi/5
    //[ResponseType(typeof(void))]
    //public IHttpActionResult PutGenre(int id, Genre genre)
    //{
    //	if (!ModelState.IsValid)
    //	{
    //		return BadRequest(ModelState);
    //	}

    //	if (id != genre.GenreId)
    //	{
    //		return BadRequest();
    //	}

    //	db.Entry(genre).State = EntityState.Modified;

    //	try
    //	{
    //		db.SaveChanges();
    //	}
    //	catch (DbUpdateConcurrencyException)
    //	{
    //		if (!GenreExists(id))
    //		{
    //			return NotFound();
    //		}
    //		else
    //		{
    //			throw;
    //		}
    //	}

    //	return StatusCode(HttpStatusCode.NoContent);
    //}
    [HttpPut]
    public IHttpActionResult Update(int id, AdministradorEquipoDTO administradorEquipoDTO)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var administradorEquipoInPersistence = _UnityOfWork.AdministradorEquipos.Get(id);
        if (administradorEquipoInPersistence == null)
            return NotFound();

        Mapper.Map<AdministradorEquipoDTO, AdministradorEquipo>(administradorEquipoDTO, administradorEquipoInPersistence);

        _UnityOfWork.SaveChanges();

        return Ok(administradorEquipoDTO);
    }


    // POST: api/GenresApi
    //[ResponseType(typeof(Genre))]
    //public IHttpActionResult PostGenre(Genre genre)
    //{
    //	if (!ModelState.IsValid)
    //	{
    //		return BadRequest(ModelState);
    //	}

    //	db.Genres.Add(genre);
    //	db.SaveChanges();

    //	return CreatedAtRoute("DefaultApi", new { id = genre.GenreId }, genre);
    //}
    [HttpPost]
    public IHttpActionResult Create(AdministradorEquipoDTO administradorEquipoDTO)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var administradorEquipo = Mapper.Map<AdministradorEquipoDTO, AdministradorEquipo>(administradorEquipoDTO);

        _UnityOfWork.AdministradorEquipos.Add(administradorEquipo);
        _UnityOfWork.SaveChanges();

        administradorEquipoDTO.AdministradorEquipoId = administradorEquipo.AdministradorEquipoClienteId;

        return Created(new Uri(Request.RequestUri + "/" + administradorEquipo.AdministradorEquipoId), administradorEquipoDTO);
    }

    // DELETE: api/GenresApi/5
    //[ResponseType(typeof(Genre))]
    //public IHttpActionResult DeleteGenre(int id)
    //{
    //	Genre genre = db.Genres.Find(id);
    //	if (genre == null)
    //	{
    //		return NotFound();
    //	}

    //	db.Genres.Remove(genre);
    //	db.SaveChanges();

    //	return Ok(genre);
    //}
    [HttpDelete]
    public IHttpActionResult Delete(int id)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var clienteInDataBase = _UnityOfWork.Clientes.Get(id);
        if (clienteInDataBase == null)
            return NotFound();

        _UnityOfWork.AdministradorEquipos.Delete(administradorEquipoInDataBase);
        _UnityOfWork.SaveChanges();

        return Ok();
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