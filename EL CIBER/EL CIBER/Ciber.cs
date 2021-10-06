using System.Collections.Generic;
using System.Text;

namespace EL_CIBER
{
    public class Ciber
    {
        private List<Computadoras> computadora;
        private Queue<Clientes> clientardos;

        public List<Computadoras> Computadora
        {
            get { return this.computadora; }
        }
        public Queue<Clientes>Clientes
        {
            get { return this.clientardos; }
        }
        public Ciber()
        {
            this.computadora = new List<Computadoras>();
            this.clientardos = new Queue<Clientes>();
        }

        public string listarCompus()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Computadoras specs in this.computadora)
            {
                sb.AppendLine(specs.Listar());
            }
            return sb.ToString();
        }
        public string listarClientes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Clientes specs in this.clientardos)
            {
                sb.AppendLine(specs.listarClientes());
            }
            return sb.ToString();
        }
        public static bool operator ==(Ciber c1, Computadoras e1)
        {
            foreach (Computadoras item in c1.Computadora)
            {
               if(item.Identificador==e1.Identificador)
                {
                    return true;
                }    
            }
            return false;
        }
        public static bool operator !=(Ciber c1, Computadoras e1)
        {
            return !(c1 != e1);
        }

        public static Ciber operator +(Ciber c1, Computadoras e1)
        {
            foreach (Computadoras spec in c1.computadora)
            {
                if (spec == e1)
                {
                    return c1;
                }
            }
            c1.computadora.Add(e1);
            return c1;
        }
        public static Ciber operator +(Ciber c1, Clientes cli1)
        {
            foreach (Clientes cli in c1.clientardos)
            {
                if (cli == cli1)
                {
                    return c1;
                }
            }
            c1.clientardos.Enqueue(cli1);
            return c1;
        }
    }
}
