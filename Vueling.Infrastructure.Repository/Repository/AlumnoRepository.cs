using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Layer;
using Vueling.Domain.Model.Entities;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.DataModel;

namespace Vueling.Infrastructure.Repository.Repository
{
    public class AlumnoRepository : IRepository<AlumnoEntity>
    {

        public AlumnoEntity Add(AlumnoEntity model)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // YOU MUST LOG
                throw new VuelingException("Error en la actualización", ex);
            }
            catch (DbUpdateException ex)
            {
                // ex.Message o ex.Data o ex.StackTrace; 
                // YOU MUST LOG
                throw new VuelingException("Error en la actualización", ex);
            }
            catch (DbEntityValidationException ex) // ex.message
            {
                // YOU MUST LOG
                throw new VuelingException("Error en la actualización", ex);
            }
            catch (NotSupportedException ex)
            {
                // YOU MUST LOG
                throw new VuelingException("Error en la actualización", ex);
            }
            catch (ObjectDisposedException ex)
            {
                // YOU MUST LOG
                throw new VuelingException("Error en la actualización", ex);
            }
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
