using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Domain.Model.Entities;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.DataModel;

namespace Vueling.Infrastructure.Repository.Repository
{
    public class AlumnoRepository : IRepository<AlumnoEntity>
    {

        public AlumnoEntity Add(AlumnoEntity model)
        {
            throw new NotImplementedException();  // aqui se haria el automapper
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }


        public AlumnoEntity Update(AlumnoEntity model)
        {
            throw new NotImplementedException();
        }

        List<AlumnoEntity> IRepository<AlumnoEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        AlumnoEntity IRepository<AlumnoEntity>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
