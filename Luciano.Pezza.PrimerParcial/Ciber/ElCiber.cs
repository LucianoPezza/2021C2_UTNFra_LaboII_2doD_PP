using System.Collections.Generic;
using System.Text;

namespace Ciber
{
    public class ElCiber
    {
        private List<Computadoras> computadora;
        private Queue<Clientes> clientardos;
        private List<Telefono> llamadas;


        public List<Computadoras> Computadora
        {
            get { return this.computadora; }
        }
        public List<Telefono> Llamadas
        {
            get { return this.llamadas; }
        }
        public Queue<Clientes> Clientes
        {
            get { return this.clientardos; }
        }
        public ElCiber()
        {
            this.computadora = new List<Computadoras>();
            this.clientardos = new Queue<Clientes>();
            this.llamadas = new List<Telefono>();
        }

        public string listarCompus()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Computadoras specs in this.computadora)
            {
                if (specs.Estado == false)
                {
                    sb.AppendLine(specs.ToString());
                    sb.AppendLine("---------------------------------------------------------------");
                }
            }
            return sb.ToString();
        }
        public string listarClientes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Clientes specs in this.clientardos)
            {
                if (specs.Atendido == false)
                {
                    sb.AppendLine(specs.listarClientes());
                }
                sb.AppendLine("--------------------------------------------");

            }
            return sb.ToString();
        }
        public string listarLlamadas()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Telefono item in this.llamadas)
            {
                sb.AppendLine(item.ToString());
            }


            return sb.ToString();
        }


        public static ElCiber operator +(ElCiber c1, Computadoras e1)
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
        public static ElCiber operator +(ElCiber c1, Clientes cli1)
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
        public static ElCiber operator +(ElCiber c1, Telefono cab1)
        {
            foreach (Telefono cab in c1.llamadas)
            {
                if (cab == cab1)
                {
                    return c1;
                }
            }
            c1.llamadas.Add(cab1);
            return c1;
        }

    }

}
