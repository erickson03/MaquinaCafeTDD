using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class VasoPruebas
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            // ARRANGE (preparación)
            Vaso vasosPequenos = new Vaso(2, 10);

            // ACT (acción)
            bool resultado = vasosPequenos.HayVasos(1);

            // ASSERT (verificación)
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            // ARRANGE
            Vaso vasosPequenos = new Vaso(1, 10);

            // ACT
            bool resultado = vasosPequenos.HayVasos(2);

            // ASSERT
            Assert.IsFalse(resultado);
        }


        [TestMethod]
        public void DeberiaRestarCantidadDeVasos()
        {
            // ARRANGE
            Vaso vasosPequenos = new Vaso(5, 10);

            // ACT
            vasosPequenos.DarVasos(1);

            // ASSERT
            Assert.AreEqual(4, vasosPequenos.GetCantidadVasos());
        }
    }
}