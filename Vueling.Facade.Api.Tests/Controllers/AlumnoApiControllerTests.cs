using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.Facade.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Vueling.Infrastructure.Repository.DataModel;
using Vueling.Application.Dto;

namespace Vueling.Facade.Api.Controllers.Tests
{
    [TestClass()]
    public class AlumnoApiControllerTests
    {
       
        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTest()
        {
            AlumnoApiController controller = new AlumnoApiController();

            AlumnoDto alumnoDto = new AlumnoDto();
            alumnoDto.Nombre = "Ferran";
            alumnoDto.Apellidos = "Lopez";
            alumnoDto.Dni = "23456784J";
            alumnoDto.FechaNacimiento = new DateTime(1990, 04, 07);
            IHttpActionResult actionResult =
                controller.Post(alumnoDto);

            var contentResult = actionResult as
                CreatedAtRouteNegotiatedContentResult<Alumno>;

            Assert.IsNotNull(actionResult);
            
        }

        [TestMethod()]
        public void PutTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}