using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Application.Dto;
using Vueling.Application.Services.Contracts;
using Vueling.Common.Layer;
using Vueling.Domain.Model.Entities;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.Repository;
using Vueling.Utils.LogHelper;

namespace Vueling.Application.Services.Service
{
    public class AlumnoService : IService<AlumnoDto>
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();

        private readonly IRepository<AlumnoEntity> alumnoRepository;

        public AlumnoService() : this(new AlumnoRepository ())
        {
        }

        // Arquitectura inyección de dependencia
        public AlumnoService (AlumnoRepository alumnoRepository)
        {
            this.alumnoRepository = alumnoRepository;
        }

        /// <summary>
        /// Adds new alumno.
        /// </summary>
        /// <returns>This alumnoDto returns no id, because we will do a reverse map from alumnoDto to alumno entity</returns>
        public AlumnoDto Add(AlumnoDto alumnoDto)
        {
            //AlumnoEntity alumnoEntity = new AlumnoEntity();
            AlumnoEntity alumnoEntity = null;

            var config = new MapperConfiguration(cfg => 
            cfg.CreateMap<AlumnoDto, AlumnoEntity>()
            .ForMember(dest => dest.Edad, sou => 
            sou.ResolveUsing(entity => 
            DateTime.Today.AddTicks(-entity.FechaNacimiento.Ticks).Year - 1)));

            IMapper iMapper = config.CreateMapper();

            alumnoEntity = iMapper.Map<AlumnoDto, AlumnoEntity>(alumnoDto); // envia objeto alumnoDto para hacer la conversión
            try
            {
                alumnoRepository.Add(alumnoEntity);
            }
            catch (VuelingException ex)
            {
                log.Error(Resource2.AnEx);
                //log de la excepción.
                throw;
            }

            return alumnoDto;
        }

        public List<AlumnoDto> GetAll()
        {
            List<AlumnoDto> alumnoDtos;
            List<AlumnoEntity> alumnoRepositoryLlegada;
            alumnoRepositoryLlegada = alumnoRepository.GetAll();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoDto, AlumnoEntity>());
            IMapper iMapper = config.CreateMapper();

            alumnoDtos = iMapper.Map<List<AlumnoDto>>(alumnoRepositoryLlegada);
            return alumnoDtos;
        }

        public AlumnoDto GetById(int id)
        {
            //AlumnoEntity alumnoEntity = null;

            //var config = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoDto, AlumnoEntity>());
            //IMapper iMapper = config.CreateMapper();

            //alumnoEntity = iMapper.Map<AlumnoDto, AlumnoEntity>(alumnoDto); // envia objeto alumnoDto para hacer la conversión
            //try
            //{
            //    AlumnoRepository alumno = AlumnoDto.Find(id);  // recuperara alumno por id
            //    if (alumno == null)
            //    {
            //        return NotFound(); // trabajamos con un enum que es results, y ahi hay un valor NotFound que se devuelve por http.
            //    }
            //}
            //catch (VuelingException ex)
            //{
            //    log.Error(Resource2.AnEx);
            //    //log de la excepción.
            //    throw;
            //}

            //return Ok(alumno);

            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public AlumnoDto Update(AlumnoDto model)
        {
            throw new NotImplementedException();
        }
    }
}
