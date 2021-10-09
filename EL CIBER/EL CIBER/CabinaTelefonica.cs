namespace EL_CIBER
{

    public abstract class CabinaTelefonica
    {
        public enum ETipo { Disco, Teclado}

        protected string marca;
        private ETipo tipo;
        protected string identificador;
        protected long numeroTelefonico;

        public string Tipo
        {
            get
            {
                return this.marca;
            }
        }
        protected ETipo Marca
        {
            get
            {
                return this.tipo;
            }
        }
        public long NumeroTelefonico
        {
            get
            {
                return this.numeroTelefonico;
            }
            set
            {
                this.numeroTelefonico = value;
            }
        }
        public abstract double Costo
        {
            get;
            set;
        }
        public CabinaTelefonica(string marca, ETipo tipo, string identificador)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.identificador = identificador;
        }

        public virtual string ListarLlamada()
        {
            return $"Cabina:{identificador}" +
                    $"\nMarca: {Marca}" +
                    $"\nTipo de telefono {Tipo}";
        }
    }
}
