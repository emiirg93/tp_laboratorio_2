using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPaquetesInstanciada()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }
        /// <summary>
        /// test para saber si ingresan un id repetido.
        /// </summary>
        [TestMethod]
        public void TestTrackigIDRepetido()
        {
            Correo nuevo = new Correo();
            Paquete p1 = new Paquete("Repetido", "125");
            Paquete p2 = new Paquete("Repetido", "123");

            nuevo += p1;

            try
            {
                nuevo += p2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(TrackingIDRepetidoException));
                return;
            }

            Assert.Fail("Sin excepción trackingID repetido: {0}.",p2.TrackingID);
        }

    }
}
