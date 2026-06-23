using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class MaquinaDeCafePruebas
    {
        [TestMethod]
        public void DeberiaDevolverVasoPequeno()
        {
            // ARRANGE
            MaquinaDeCafe maquina = new MaquinaDeCafe(
           new Cafetera(50),
           new Vaso(5, 3),
           new Vaso(5, 5),
           new Vaso(5, 7),
           new Azucarero(20)
           );

            Vaso vaso = maquina.GetTipoDeVaso("pequeno");

            // ASSERT
            Assert.IsNotNull(vaso);
        }

        [TestMethod]
        public void DeberiaDevolverVasoMediano()
        {
            MaquinaDeCafe maquina = new MaquinaDeCafe(
           new Cafetera(50),
           new Vaso(5, 3),
           new Vaso(5, 5),
           new Vaso(5, 7),
           new Azucarero(20)
           );

            Vaso vaso = maquina.GetTipoDeVaso("mediano");

            Assert.IsNotNull(vaso);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayVasos()
        {
            MaquinaDeCafe maquina = new MaquinaDeCafe(
            new Cafetera(50),
            new Vaso(5, 3),
            new Vaso(5, 5),
            new Vaso(5, 7),
            new Azucarero(20)
            );

            Vaso vaso = maquina.GetTipoDeVaso("pequeno");

            string resultado = maquina.GetVasoDeCafe(vaso, 10, 2);

            Assert.AreEqual("No hay Vasos", resultado);
        }


    }
}