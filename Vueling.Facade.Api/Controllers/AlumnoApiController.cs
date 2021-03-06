﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Vueling.Application.Dto;
using Vueling.Application.Services.Contracts;
using Vueling.Application.Services.Service;
using Vueling.Common.Layer;
using System.Resources;
using Vueling.Infrastructure.Repository.DataModel;

namespace Vueling.Facade.Api.Controllers
{

    public class AlumnoApiController : ApiController
    {
        private readonly IService<AlumnoDto> alumnoService;

        private CovalcoEntities db = new CovalcoEntities();

        public AlumnoApiController() : this(new AlumnoService())
        {
        }

        // Arquitectura inyección de dependencia
        public AlumnoApiController(AlumnoService alumnoService)
        {
            this.alumnoService = alumnoService;
        }

        // GET: api/AlumnoApi
        public IEnumerable<AlumnoDto> Get()
        {
            return alumnoService.GetAll();
        }

        // GET: api/AlumnoApi/5
        public AlumnoDto Get(int id)
        {
            return alumnoService.GetById(id);
            // ok alumno
        }

        // POST: api/AlumnoApi
        [ResponseType(typeof(AlumnoDto))]
        public IHttpActionResult Post(AlumnoDto alumnoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            AlumnoDto alumnoDtoInsert = null;

            try
            {
               alumnoDtoInsert =
                        alumnoService.Add(alumnoDto); // el add devuelve alumnoDto
            }
            catch (VuelingException ex)
            {
                // return the best http error
            } 

            return CreatedAtRoute(Resource1.DefApi, 
                new { id = alumnoDtoInsert.Id }, alumnoDtoInsert);

            //return CreatedAtRoute("DefaultApi", new { id = alumno.Id }, alumno);
        }

        // PUT: api/AlumnoApi/5
        public IHttpActionResult Put(int id, AlumnoDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            alumnoService.Update(model);
            return StatusCode(HttpStatusCode.NoContent);
            //devuelve status code no content
        }

        // DELETE: api/AlumnoApi/5
        public IHttpActionResult Delete(int id)
        {
            return Ok(alumnoService.Remove(id));
            // ok and alumno or id
        }
    }
}
