using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Ciber
{
    public class Computadoras
    {
        public enum ESoftware { Office, Ares, Messenger, Icq, Nero }
        public enum EPerifericosDisponibles { Auriculares, Microfono, Camara, Nada }
        public enum EJuegosDisponibles { WarcraftIII, AgeOfEmpiresII, DiabloII, MUHOT, CounterStrike, LinageII }
        public enum EHardware { Pentium4, PentiumGold, Pentium3, Ryzen9_7800x };

        private List<ESoftware> software;
        private List<EPerifericosDisponibles> perifericos;
        private List<EJuegosDisponibles> juegos;
        private EHardware hardware;
        private int tiempoDeUso;
        private string identificador;
        private bool estado;
        private double cobro;
        private bool compuLibre;
        Stopwatch temporizador = new Stopwatch();
        private TimeSpan tiempoDeUsoLibreCalculado = new TimeSpan();


        public List<ESoftware> Software
        {
            get { return this.software; }
            set { this.software = value; }
        }
        public List<EPerifericosDisponibles> Perifericos
        {
            get { return this.perifericos; }
            set { this.perifericos = value; }
        }
        public List<EJuegosDisponibles> Juegos
        {
            get { return this.juegos; }
            set { this.juegos = value; }
        }
        public EHardware Hardware
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
        public int TiempoDeUso
        {
            get { return this.tiempoDeUso; }
            set { this.tiempoDeUso = value; }
        }
        public double Cobro
        {
            get { return this.cobro; }
            set { this.cobro = value; }
        }
        public TimeSpan TiempoDeUsoLibre
        {
            get { return this.tiempoDeUsoLibreCalculado; }
            set { this.tiempoDeUsoLibreCalculado = value; }
        }
        public Stopwatch Temporizador
        {
            get { return this.temporizador; }
            set { this.temporizador = value; }
        }
        public bool ComputadoraLibre
        {
            get { return this.compuLibre; }
            set { this.compuLibre = value; }
        }

        public Computadoras(List<ESoftware> software, List<EPerifericosDisponibles> perifericos, List<EJuegosDisponibles> juegos, EHardware hardware, string identificador, bool estado)
        {
            this.software = software;
            this.perifericos = perifericos;
            this.juegos = juegos;
            this.identificador = identificador;
            this.estado = estado;
            this.hardware = hardware;
            this.cobro = 0.50;
        }

        public string Listar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Identificador de PC : {Identificador} ");
            sb.AppendLine($"Hardware: {Hardware}\n");

            sb.AppendLine("Juegos disponibles: ");
            foreach (EJuegosDisponibles juegos in this.juegos)
            {
                sb.AppendLine(juegos.ToString());
            }
            sb.AppendLine("\nSoftware disponible: ");
            foreach (ESoftware software in this.software)
            {
                sb.AppendLine(software.ToString());
            }
            sb.AppendLine("\nPerifericos disponibles: ");
            foreach (EPerifericosDisponibles perfericos in this.perifericos)
            {
                sb.AppendLine(perfericos.ToString());
            }
            return sb.ToString();
        }

        public static bool operator ==(Computadoras e1, Computadoras e2)
        {
            if (e1.Identificador == e2.Identificador || e1.Hardware == e2.Hardware)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Computadoras e1, Computadoras e2)
        {
            return !(e1 == e2);
        }

        public override string ToString()
        {
            return Listar();
        }
    }
}
