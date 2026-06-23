using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class AzucareroPruebas
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiHayAzucarSuficiente()
        {
            // ARRANGE
            Azucarero azucarero = new Azucarero(10);

            // ACT
            bool resultado = azucarero.HayAzucar(5);

            // ASSERT
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoHayAzucarSuficiente()
        {
            // ARRANGE
            Azucarero azucarero = new Azucarero(5);

            // ACT
            bool resultado = azucarero.HayAzucar(10);

            // ASSERT
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucar()
        {
            // ARRANGE
            Azucarero azucarero = new Azucarero(10);

            // ACT
            azucarero.DarAzucar(3);

            // ASSERT
            Assert.AreEqual(7, azucarero.GetCantidadAzucar());
        }
    }
}