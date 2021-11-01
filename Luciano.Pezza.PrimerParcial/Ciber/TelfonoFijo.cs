using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public class TelfonoFijo : CabinaTelefonica
    {
        private double costo;
        public TelfonoFijo(string marca, ETipo tipo, string identidicador, bool estado)
       : base(marca, tipo, identidicador,estado)
        {

        }

        public override double Costo
        {
            get { return this.costo; }
            set { this.costo = value; }
        }
        public override string ListarLlamada()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ListarLlamada());
            sb.AppendLine($"Costo: {Costo}");
            return sb.ToString();
        }
        public double calcularCostoLlamada(string numeroTelefonicoAux)
        {
            string numeroTel = numeroTelefonicoAux;
            Costo = 0;
            if (numeroTel.Length > 11 && numeroTel.Length < 13)
            {
                if (numeroTel.Substring(2, 2) == "11")
                {
                    Costo = 2;
                }
                else if (numeroTel.Substring(2, 2) != "11")
                {
                    Costo = 2.50D;
                }
                if (numeroTel.Substring(0, 2) != "54")
                {
                    Costo = 5;
                }
            }
            else
            {
                Costo = 0;
            }
            return Costo;
        }
        public override string ToString()
        {
            return ListarLlamada();
        }
        public static bool operator ==(TelfonoFijo c1, TelfonoFijo c2)
        {
            return c1.identificador == c2.identificador;
        }
        public static bool operator !=(TelfonoFijo c1, TelfonoFijo c2)
        {
            return !(c1 == c2);
        }
    }
}
