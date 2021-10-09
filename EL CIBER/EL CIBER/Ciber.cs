using System.Collections.Generic;
using System.Text;

namespace EL_CIBER
{
    public class Ciber
    {
        private List<Computadoras> computadora;
        private Queue<Clientes> clientardos;
        private Llamada[] llamadas;


        public List<Computadoras> Computadora
        {
            get { return this.computadora; }
        }
        public Llamada[] Llamadas
        {
            get { return this.llamadas; }
        }
        public Queue<Clientes>Clientes
        {
            get { return this.clientardos; }
        }
        public Ciber(int index)
        {
            this.computadora = new List<Computadoras>();
            this.clientardos = new Queue<Clientes>();
            this.llamadas = new Llamada[index];
        }

        public string listarCompus()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Computadoras specs in this.computadora)
            {
                sb.AppendLine(specs.ToString());
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
        public string listarLlamadas()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.llamadas.Length; i++)
            {
                sb.AppendLine(this.llamadas[i].ToString());
            }
                
            
            return sb.ToString();
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
        //public static Ciber operator +(Ciber c1, Llamada cab1)
        //{
        //    foreach  (Llamada cab in c1.llamadas)
        //    {
        //        if(cab==cab1)
        //        {
        //            return c1;
        //        }
        //    }
        //    c1.llamadas.Add(cab1);
        //    return c1;
        //}

    }
}
