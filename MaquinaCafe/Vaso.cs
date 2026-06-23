namespace MaquinaCafe
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cantidad, int contenido)
        {
            this.cantidadVasos = cantidad;
            this.contenido = contenido;
        }

        public bool HayVasos(int cantidadSolicitada)
        {
            return cantidadVasos >= cantidadSolicitada;
        }

        public int GetCantidadVasos()
        {
            return cantidadVasos;
        }

        public void DarVasos(int cantidad)
        {
            cantidadVasos -= cantidad;
        }
    }
}