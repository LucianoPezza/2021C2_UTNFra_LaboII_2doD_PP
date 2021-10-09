using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL_CIBER
{
    public class Llamada:CabinaTelefonica
    {
        private double costo;
        public Llamada(string marca, ETipo tipo,string identidicador)
       : base(marca, tipo, identidicador)
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
        public double calcularCostoLlamada(long numeroTelefonicoAux)
        {
            NumeroTelefonico = numeroTelefonicoAux;
            string numeroTel = NumeroTelefonico.ToString();
            Costo = 0;
            if(numeroTel.Substring(2,2)=="11")
            {
                Costo = 2;
            }
            else if(numeroTel.Substring(2,2)!="11")
            {
                Costo=2.50D;
            }
            if(numeroTel.Substring(0,2)!="54")
            {
                Costo = 5;
            }

            return Costo;
        }
        public override string ToString()
        {
            return ListarLlamada();
        }
    }
}
