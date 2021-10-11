using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public class Clientes
    {

        private string nombre;
        private long dni;
        private int edad;
        private string apellido;
        private bool atendido;

        public string Nombre
        {
            get { return this.nombre; }
        }
        public long DNI
        {
            get { return this.dni; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public int Edad
        {
            get { return this.edad; }
        }
        public bool Atendido
        {
            get { return this.atendido; }
            set { this.atendido = value; }
        }


        public Clientes(string nombre, long dni, string apellido, int edad, bool atendido)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.apellido = apellido;
            this.edad = edad;
            this.atendido = atendido;
        }

        public string listarClientes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"DNI: {DNI}");


            return sb.ToString();
        }


        public static bool operator ==(Clientes c1, Clientes c2)
        {
            if (c1.DNI == c2.DNI)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Clientes c1, Clientes c2)
        {
            return !(c1 == c2);
        }

    }
}
