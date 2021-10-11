using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public abstract class CabinaTelefonica
    {
        public enum ETipo { Disco, Teclado }
        private bool estado;
        protected string marca;
        private ETipo tipo;
        protected string identificador;

        public string Marca
        {
            get
            {
                return this.marca;
            }
        }
       
        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
        }
        public bool Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public string Identificador
        {
            get
            {
                return this.identificador;
            }
        }

        public abstract double Costo
        {
            get;
            set;
        }
        public CabinaTelefonica(string marca, ETipo tipo, string identificador, bool estado)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.identificador = identificador;
            this.estado = estado;
        }

        public virtual string ListarLlamada()
        {
            return $"Cabina:{identificador}" +
                    $"\nMarca: {Marca}" +
                    $"\nTipo de telefono {Tipo}";
        }

    }
}
