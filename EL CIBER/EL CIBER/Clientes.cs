using System;
using System.Text;
namespace EL_CIBER
{
    public class Clientes
    {

        private string nombre;
        private long dni;
        private int edad;
        private string apellido;
        private bool atendido;
        private string juegoDeseado;
        private string softwareDeseado;
        private string harwareDeseado;
        private string perifericoDeseado;
      
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
        }
        public string JuegoDeseado
        {
            get { return this.juegoDeseado; }
        }
        public string SoftwareDeseado
        {
            get { return this.softwareDeseado; }
        }
        public string HarwareDeseado
        {
            get { return this.harwareDeseado; }
        }
        public string PerifericoDeseado
        {
            get { return this.perifericoDeseado; }
        }

        public Clientes(string nombre, long dni, string apellido, int edad, bool atendido)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.apellido = apellido;
            this.edad = edad;
            this.atendido = atendido;
            this.softwareDeseado = valorRandomSoftware();
            this.harwareDeseado = valorRandomHardware();
            this.juegoDeseado = valorRandomJuegos();
            this.perifericoDeseado = valorRandomPerifericos();
        }

        public string listarClientes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"DNI: {DNI}");
            sb.AppendLine($"Software Deseado: {SoftwareDeseado}");
            sb.AppendLine($"Hardware Deseado: {HarwareDeseado}");
            sb.AppendLine($"Juego Deseado: {JuegoDeseado}");
            sb.AppendLine($"Periferico Deseado: {PerifericoDeseado}");

            return sb.ToString();
        }

        public string valorRandomHardware()
        {

            Random random = new Random();
            int intRandom = random.Next(1, 5);
            string stringRandom = "";
            switch (intRandom)
            {
                case 1:
                    stringRandom = "Pentium4";
                    break;
                case 2:
                    stringRandom = "PentiumGold";
                    break;
                case 3:
                    stringRandom = "Pentium3";
                    break;
                case 4:
                    stringRandom = "Ryzen9_7800x";
                    break;
            }
            return stringRandom;
        }
        public string valorRandomJuegos()
        {
            Random random = new Random();
            int intRandom = random.Next(1, 6);
            string stringRandom="";
            switch (intRandom)
            {
                case 1:
                    stringRandom = "WarcraftIII";
                    break;
                case 2:
                    stringRandom = "AgeOfEmpiresII";
                    break;
                case 3:
                    stringRandom = "CounterStrike";
                    break;
                case 4:
                    stringRandom = "DiabloII";
                    break;
                case 5:
                    stringRandom = "LinageII";
                    break;
                case 6:
                    stringRandom = "MUHOT";
                    break;
            }
            return stringRandom;
        }

        public string valorRandomPerifericos()
        {
            Random random = new Random();
            string stringRandom = "";
            int intRandom = random.Next(1, 4);

            switch (intRandom)
            {
                case 1:
                    stringRandom = "Auricular";
                    break;
                case 2:
                    stringRandom = "Microfono";
                    break;
                case 3:
                    stringRandom = "Camara";
                    break;
            }
            return stringRandom;
        }

        public string valorRandomSoftware()
        {
            Random random = new Random();
            string stringRandom = "";
            int intRandom = random.Next(1, 6);

            switch (intRandom)
            {
                case 1:
                    stringRandom = "Messenger";
                    break;
                case 2:
                    stringRandom = "Ares";
                    break;
                case 3:
                    stringRandom = "Icq";
                    break;
                case 4:
                    stringRandom = "Office";
                    break;
                case 5:
                    stringRandom = "Nero";
                    break;
            }
            return stringRandom;
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
