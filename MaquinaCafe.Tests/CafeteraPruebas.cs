using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class CafeteraPruebas
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            // ARRANGE
            Cafetera cafetera = new Cafetera(10);

            // ACT
            bool resultado = cafetera.HayCafe(5);

            // ASSERT
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            // ARRANGE
            Cafetera cafetera = new Cafetera(5);

            // ACT
            bool resultado = cafetera.HayCafe(10);

            // ASSERT
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafe()
        {
            // ARRANGE
            Cafetera cafetera = new Cafetera(10);

            // ACT
            cafetera.DarCafe(7);

            // ASSERT
            Assert.AreEqual(3, cafetera.GetCantidadCafe());
        }
    }
}