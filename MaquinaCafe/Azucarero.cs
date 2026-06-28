namespace MaquinaCafe
{
    public class Azucarero
    {
        private int cantidadAzucar;

        public Azucarero(int cantidadInicial)
        {
            this.cantidadAzucar = cantidadInicial;
        }

        public bool HayAzucar(int cantidadSolicitada)
        {
            return cantidadAzucar >= cantidadSolicitada;
        }

        public int GetCantidadAzucar()
        {
            return cantidadAzucar;
        }

        public void DarAzucar(int cantidad)
        {
            cantidadAzucar -= cantidad;
        }
    }
}

// Cambio realizado en feature para CI/CD