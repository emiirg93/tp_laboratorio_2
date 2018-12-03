using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using ClasesAbstractas;
using ClasesInstanciables;
using System.Threading.Tasks;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestNull()
        {
            Profesor p = new Profesor(111, "Jonatan", "Calleri", null, Persona.ENacionalidad.Argentino);    
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadException()
        {
            Alumno uno = new Alumno(222, "Mauro", "Zarate", "3767464", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
        }

        [TestMethod]
        public void TestValorNumerico()
        {
            Alumno alumno = new Alumno(333, "Pipa", "Benedetto", "37904306", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            Assert.IsInstanceOfType(alumno.DNI, typeof(int));
        }
    }
}
