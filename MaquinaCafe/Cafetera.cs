namespace MaquinaCafe
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadInicial)
        {
            this.cantidadCafe = cantidadInicial;
        }

        public bool HayCafe(int cantidadSolicitada)
        {
            return cantidadCafe >= cantidadSolicitada;
        }

        public int GetCantidadCafe()
        {
            return cantidadCafe;
        }

        public void DarCafe(int cantidad)
        {
            cantidadCafe -= cantidad;
        }
    }
}