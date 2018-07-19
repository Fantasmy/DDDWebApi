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
using Vueling.Utils.LogHelper;

namespace Vueling.Infrastructure.Repository.Repository
{
    public class AlumnoRepository : IRepository<AlumnoEntity>
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();


        public AlumnoEntity Add(AlumnoEntity model)
        {
            //private CovalcoEntities db = new CovalcoEntities();

            //db.Alumno.Add(alumno);  
            //db.SaveChanges();

            try
            {
                throw new NotImplementedException();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // YOU MUST LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (DbUpdateException ex)
            {
                // ex.Message o ex.Data o ex.StackTrace; 
                // YOU MUST LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (DbEntityValidationException ex) // ex.message
            {
                // YOU MUST LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (NotSupportedException ex)
            {
                // YOU MUST LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (ObjectDisposedException ex)
            {
                // YOU MUST LOG
                throw new VuelingException(Resource3.ErAct, ex);
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
