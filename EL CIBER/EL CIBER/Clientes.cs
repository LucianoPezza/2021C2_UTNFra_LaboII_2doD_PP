namespace EL_CIBER
{
    public class Clientes
    {

        protected string nombre;
        protected long dni;
        protected int edad;
        protected string apellido;
        protected bool atendido;
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
            return $"Nombre: {Nombre}" +
                  $"\nApellido: {Apellido}" +
                  $"\nEdad: {Edad}" +
                  $"\nDNI: {DNI}" +
                  $"\nAtendido: {atendido}\n";
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
