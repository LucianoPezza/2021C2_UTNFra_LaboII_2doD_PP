using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL_CIBER;

namespace CiberWindowsForm
{
    public partial class FormClientesALaEspera : Form
    {
        public FormClientesALaEspera()
        {
            InitializeComponent();
        }

        private void ClientesALaEspera_Load(object sender, EventArgs e) 
        {

            Ciber c1 = new Ciber();

            Computadoras com1 = new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() {},
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.AgeOfEmpiresII, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Pentium3, "C01", false);
            
            Computadoras com2 = new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EPerifericosDisponibles.Camara },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.AgeOfEmpiresII, Computadoras.EJuegosDisponibles.MUHOT, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Pentium3, "C01", false);

            Computadoras com3 = new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EPerifericosDisponibles.Camara },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.LinageII, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Pentium3, "C01", false);
            
            Computadoras com4 = new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EPerifericosDisponibles.Camara },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.AgeOfEmpiresII, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Pentium3, "C01", false);
            
            Computadoras com5 = new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EPerifericosDisponibles.Camara },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.AgeOfEmpiresII},
            Computadoras.EHardware.Pentium3, "C01", false);

            //Computadoras e2 = new Computadoras(Computadoras.ESoftware.Ares, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.WarcraftIII, Computadoras.EHardware.Pentium4, "C2", true);
            //Computadoras e3 = new Computadoras(Computadoras.ESoftware.Icq, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.LinageII, Computadoras.EHardware.PentiumGold, "C3", false);
            //Computadoras e4 = new Computadoras(Computadoras.ESoftware.Office, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.MUHOT, Computadoras.EHardware.Ryzen9_7800x, "C4", false);
            //Computadoras e5 = new Computadoras(Computadoras.ESoftware.Nero, Computadoras.EPerifericosDisponibles.Auriculares, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EHardware.PentiumGold, "C5", false);

            Clientes cli1 = new Clientes("Lucas", 123, "Perez", 69, false);
            Clientes cli2 = new Clientes("Luciano", 321, "Pezza", 20, false);
            Clientes cli3 = new Clientes("Mauricio", 32, "Cerizza", 30, false);
            Clientes cli31 = new Clientes("Mauricio", 32, "Cerizza", 30, false);
            Clientes cli32 = new Clientes("Mauricio", 32, "Cerizza", 30, false);
            Clientes cli33 = new Clientes("Mauricio", 32, "Cerizza", 30, false);
            Clientes cli4 = new Clientes("Lautaro", 4, "Galarza", 23, false);
            Clientes cli5 = new Clientes("Marcos", 5, "Oppioso", 20, false);
            Clientes cli6 = new Clientes("Eric", 6, "Cartman", 8, false);
            Clientes cli7 = new Clientes("Peter", 7, "Griffin", 40, false);
            Clientes cli8 = new Clientes("Leando", 8, "Montenegro", 18, false);
            Clientes cli9 = new Clientes("Homero", 9, "Simpson", 40, false);
            Clientes cli10 = new Clientes("Troy", 10, "McClure", 40, false);


            //c1 += e2;
            //c1 += e3;
            //c1 += e4;
            //c1 += e5;

            c1 += cli1;
            c1 += cli2;
            c1 += cli3;
            c1 += cli4;
            c1 += cli5;
            c1 += cli6;
            c1 += cli7;
            c1 += cli8;
            c1 += cli9;
            c1 += cli10;

            txtClientesALAEspera.Text = c1.listarCompus();
            //foreach (Computadoras item in c1.Computadora)
            //{
            //    if (item.Software.ToString() == auxstr && item.Estado == false)
            //    {
            //        MessageBox.Show(item.Listar());

            //    }
            //}


            //txtClientesALAEspera.Text=c1.listarClientes();

        }
       
    }
}
