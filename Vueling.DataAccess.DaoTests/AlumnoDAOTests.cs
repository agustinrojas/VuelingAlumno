using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic;



namespace Vueling.DataAccess.Dao.Tests
{
    [TestClass()]
    public class AlumnoDAOTests
    {
        [DataRow(1, "Agus", "Rojas", "1234", "02/04/1994", "04/04/2018")]
        [DataTestMethod]
        public void txtTest(int id, string nombre, string apellidos, string dni, string nacimiento, string registro, Guid guid)
        {
            Alumno alumno1 = new Alumno(id, nombre, apellidos, dni, nacimiento, registro, guid);
            Assert.IsTrue(guid == alumno1.GUID);
            Assert.IsTrue(id == alumno1.ID);
            Assert.IsTrue(nombre == alumno1.NOMBRE);
            Assert.IsTrue(apellidos == alumno1.APELLIDOS);
            Assert.IsTrue(dni == alumno1.DNI);
        }

        [DataRow(1, "Agus", "Rojas", "1234", "02/04/1994", "04/04/2018")]
        [DataTestMethod]
        public void jsonTest(int id, string nombre, string apellidos, string dni, string nacimiento, string registro, Guid guid)
        {
            ClaseAlumno alumno1 = new ClaseAlumno(id, nombre, apellidos, dni, guid);
            Assert.IsTrue(guid == alumno1.GUID);
            Assert.IsTrue(id == alumno1.ID);
            Assert.IsTrue(nombre == alumno1.NOMBRE);
            Assert.IsTrue(apellidos == alumno1.APELLIDOS);
            Assert.IsTrue(dni == alumno1.DNI);
        }
        [DataRow(1, "Agus", "Rojas", "1234", "02/04/1994", "04/04/2018")]
        [DataTestMethod]
        public void xmlTest(int id, string nombre, string apellidos, string dni, string nacimiento, string registro, Guid guid)
        {
            ClaseAlumno alumno1 = new ClaseAlumno(id, nombre, apellidos, dni, guid);
            Assert.IsTrue(guid == alumno1.GUID);
            Assert.IsTrue(id == alumno1.ID);
            Assert.IsTrue(nombre == alumno1.NOMBRE);
            Assert.IsTrue(apellidos == alumno1.APELLIDOS);
            Assert.IsTrue(dni == alumno1.DNI);
        }
    }
}