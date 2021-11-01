using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public class Telefono : CabinaTelefonica
    {
        private double costo;
        public Telefono(string marca, ETipo tipo, string identidicador, bool estado)
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
            double auxCosto;
            auxCosto = 0;
            if (numeroTel.Length > 11 && numeroTel.Length < 13 && double.TryParse(numeroTel,out auxCosto))
            {
                if (numeroTel.Substring(2, 2) == "11")
                {
                    auxCosto = 2;
                }
                else if (numeroTel.Substring(2, 2) != "11")
                {
                    auxCosto = 2.50D;
                }
                if (numeroTel.Substring(0, 2) != "54")
                {
                    auxCosto = 5;
                }
            }
            else
            {
                auxCosto = 0;
            }

            return Costo=auxCosto;
        }
        public override string ToString()
        {
            return ListarLlamada();
        }
        public static bool operator ==(Telefono c1, Telefono c2)
        {
            return c1.identificador == c2.identificador;
        }
        public static bool operator !=(Telefono c1, Telefono c2)
        {
            return !(c1 == c2);
        }
    }
}
