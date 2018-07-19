using AutoMapper;
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

        private readonly CovalcoEntities db;

        public AlumnoRepository() : this(new CovalcoEntities())
        {

        }

        public AlumnoRepository(
            CovalcoEntities covalcoEntities)
        {
            this.db = covalcoEntities;
        }

        public AlumnoEntity Add(AlumnoEntity model)
        {
            Alumno alumno = null;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoEntity, Alumno>());
            IMapper iMapper = config.CreateMapper();
            alumno = iMapper.Map<AlumnoEntity, Alumno>(model);

            try
            {
                db.Alumno.Add(alumno);
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //You Must LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (DbUpdateException ex)
            {
                //You Must LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (DbEntityValidationException ex)
            {
                //You Must LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (NotSupportedException ex)
            {
                //You Must LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (ObjectDisposedException ex)
            {
                //You Must LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            catch (InvalidOperationException ex)
            {
                //You Must LOG
                throw new VuelingException(Resource3.ErAct, ex);
            }
            return model;
        }

        public List<AlumnoEntity> GetAll()
        {
            List<AlumnoEntity> alumnoEntity;
            IQueryable<Alumno> listaAlumno;
            try
            {
                listaAlumno = db.Alumno;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //You Must LOG
                throw new VuelingException("mensaje de error que debe estar en el fichero de recueros", ex);
            }
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Alumno, AlumnoEntity>());
            IMapper iMapper = config.CreateMapper();

            alumnoEntity = iMapper.Map<List<AlumnoEntity>>(listaAlumno);

            return alumnoEntity;
        }

        public AlumnoEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public AlumnoEntity Update(AlumnoEntity model)
        {
            throw new NotImplementedException();
        }

    }
}
