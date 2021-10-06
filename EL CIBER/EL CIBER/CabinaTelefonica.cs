namespace EL_CIBER
{
    public class CabinaTelefonica
    {
        private string tipo;
        private string marca;
        private long numeroTelefonico;
        protected string Tipo
        {
            get
            { return tipo; }
        }
        protected string Marca
        {
            get
            { return marca; }
        } protected long NumeroTelefonico
        {
            get
            { return NumeroTelefonico; }
        }

        public CabinaTelefonica(string tipo, string marca,long numeroTelefonico)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.numeroTelefonico = numeroTelefonico;
        }

    }
}
