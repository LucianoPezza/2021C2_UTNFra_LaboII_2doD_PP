using System.Collections.Generic;

namespace EL_CIBER
{
    public class Computadoras
    {
        public enum ESoftware { Office, Ares, Messenger, Icq, Nero }
        public enum EPerifericosDisponibles { Auriculares, Microfono, Camara }
        public enum EJuegosDisponibles { WarcraftIII, AgeOfEmpiresII, DiabloII, MUHOT, CounterStrike, LinageII }

        private ESoftware software;
        private EPerifericosDisponibles perifericos;
        private EJuegosDisponibles juegos;
        private string hardware;
        private string identificador;
        private bool estado;

        public ESoftware Software
        {
            get { return this.software; }
            set { this.software = value; }
        }
        public EPerifericosDisponibles Perifericos
        {
            get { return this.perifericos; }
            set { this.perifericos = value; }
        }
        public EJuegosDisponibles Juegos
        {
            get { return this.juegos; }
            set { this.juegos = value; }
        }
        public string Hardware
        {
            get { return this.hardware; }
            set { this.hardware = value; }
        }
        public string Identificador
        {
            get { return this.identificador; }
            set { this.identificador = value; }
        }
        public bool Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public Computadoras(ESoftware software, EPerifericosDisponibles perifericos, EJuegosDisponibles juegos, string hardware, string identificador, bool estado)
        {
            this.software = software;
            this.perifericos = perifericos;
            this.juegos = juegos;
            this.hardware = hardware;
            this.Identificador = identificador;
            this.estado = estado;
        }

        public string Listar()
        {
            return $"PC : {Identificador} " +
                  $"Software: {Software} " +
                  $"\nHardware: {Hardware}" +
                  $"\nPerifericos: {Perifericos}" +
                  $"\nJuegos: {Juegos}" +
                  $"\nOcupada: {Estado}\n";
                  
        }

        public static bool operator ==(Computadoras e1, Computadoras e2)
        {
                if(e1.identificador == e2.identificador)
                {
                    return true;
                }    
            return false;
        }
        public static bool operator !=(Computadoras e1, Computadoras e2)
        {
            return !(e1 == e2);
        }
   
    }
}
