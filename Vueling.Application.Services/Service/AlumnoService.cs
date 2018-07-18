using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Application.Dto;
using Vueling.Application.Services.Contracts;
using Vueling.Domain.Model.Entities;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.Repository;

namespace Vueling.Application.Services.Service
{
    public class AlumnoService : IService<AlumnoDto>
    {
        private readonly IRepository <AlumnoEntity> alumnoRepository;



        public AlumnoService() : this(new AlumnoRepository ())
        {
        }

        // Arquitectura inyección de dependencia
        public AlumnoService (AlumnoRepository alumnoRepository)
        {
            this.alumnoRepository = alumnoRepository;
        }

        public AlumnoDto Add(AlumnoDto model)
        {
            throw new NotImplementedException();
        }

        public List<AlumnoDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public AlumnoDto GetById(int id)
        {
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
