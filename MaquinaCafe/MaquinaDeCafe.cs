namespace MaquinaCafe
{
    public class MaquinaDeCafe
    {
        public Cafetera Cafetera { get; set; }
        public Vaso VasosPequenos { get; set; }
        public Vaso VasosMedianos { get; set; }
        public Vaso VasosGrandes { get; set; }
        public Azucarero Azucarero { get; set; }

        public MaquinaDeCafe(Cafetera cafetera, Vaso pequenos, Vaso medianos, Vaso grandes, Azucarero azucarero)
        {
            Cafetera = cafetera;
            VasosPequenos = pequenos;
            VasosMedianos = medianos;
            VasosGrandes = grandes;
            Azucarero = azucarero;
        }

        public Vaso GetTipoDeVaso(string tipo)
        {
            if (tipo == "pequeno")
                return VasosPequenos;

            if (tipo == "mediano")
                return VasosMedianos;

            if (tipo == "grande")
                return VasosGrandes;

            return null;
        }

        public string GetVasoDeCafe(Vaso vaso, int cantidadVasos, int cantidadAzucar)
        {
            if (vaso == null || !vaso.HayVasos(cantidadVasos))
                return "No hay Vasos";

            if (Cafetera == null || !Cafetera.HayCafe(5))
                return "No hay Cafe";

            if (Azucarero == null || !Azucarero.HayAzucar(cantidadAzucar))
                return "No hay Azucar";

            vaso.DarVasos(cantidadVasos);
            Cafetera.DarCafe(5);
            Azucarero.DarAzucar(cantidadAzucar);

            return "Felicitaciones";
        }
    }
}