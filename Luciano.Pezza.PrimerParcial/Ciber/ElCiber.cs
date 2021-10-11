﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ciber
{
    public class ElCiber
    {
        private List<Computadoras> computadora;
        private Queue<Clientes> clientardos;
        private List<Llamada> llamadas;


        public List<Computadoras> Computadora
        {
            get { return this.computadora; }
        }
        public List<Llamada> Llamadas
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
            this.llamadas = new List<Llamada>();
        }

        public string listarCompus()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Computadoras specs in this.computadora)
            {
                if (specs.Estado == true)
                {
                    sb.AppendLine("Pc En uso: \n" + specs.ToString());
                    sb.AppendLine("---------------------------------------------------------------");
                }
                else
                {
                    sb.AppendLine("Pc desocupada \n" + specs.ToString());
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

            foreach (Llamada item in this.llamadas)
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
        public static ElCiber operator +(ElCiber c1, Llamada cab1)
        {
            foreach (Llamada cab in c1.llamadas)
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
