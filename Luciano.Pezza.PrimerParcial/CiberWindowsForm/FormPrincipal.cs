using Ciber;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace CiberWindowsForm
{

    public partial class FormPrincipal : Form
    {
        ElCiber c1 = new ElCiber();
        Stopwatch stp = new Stopwatch();
        TimeSpan tSpan = new TimeSpan();
        double cobro = 0;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            c1 = CargarDatos();

            txtIdentificador.Visible = false;
            lblCabina.Visible = false;
            btnIngersarCabina.Visible = false;

            txtNumeroTelefonico.Visible = false;
            lblNumeroTelefonico.Visible = false;
            btnNumeroTelefonico.Visible = false;
            lstLlamadas.Visible = false;


            txtComputadoraIdentificador.Visible = false;
            btnIngresarIdentificadorComputadora.Visible = false;
            lblComputadoraIdentificador.Visible = false;
            lstDeseoDeClientes.Visible = false;
            
            btnTiempodePC.Visible = false;
            txtTiempoDePC.Visible = false;
            lblTiempoDeLaPc.Visible = false;


            lstDeseoDeClientes.Items.Add("El cliente "+c1.Clientes.Peek().Nombre+" Desea: " +valorRandomDeseoCliente());

            foreach (Llamada item in c1.Llamadas)
            {
                lstLlamadas.Items.Add("Identificador: " + item.Identificador + " Cabina de tipo: " + item.Tipo + "Ocupada: " + item.Estado);
            }
            lblInformacionPersonal.Text = "Pezza Luciano" + " " + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (c1.Clientes.Count > 0)
            {
                DialogResult dialogo = MessageBox.Show("Quiere asignar una cabina?", "Asignar Cabina", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.No)
                {

                    dialogo = MessageBox.Show("Quiere asignar una Computadora?", "Asignar PC", MessageBoxButtons.YesNo);
                    if (dialogo == DialogResult.Yes)
                    {
                        dialogo = MessageBox.Show("Quiere una pc Libre?", "Opcion libre", MessageBoxButtons.YesNo);
                        if (dialogo == DialogResult.No)
                        {
                            btnTiempodePC.Visible = true;
                            txtTiempoDePC.Visible = true;
                            lblTiempoDeLaPc.Visible = true;
                            btnAsignar.Enabled = false;
                            btnListarComputadoras.Enabled = false;
                            brnClientesDesatendidos.Enabled = false;
                            btnFinalizacionDeServicio.Enabled = false;
                            btnIngresarIdentificadorComputadora.Enabled = false;
                        }
                        else
                        {
                            txtComputadoraIdentificador.Visible = true;
                            btnIngresarIdentificadorComputadora.Visible = true;
                            lblComputadoraIdentificador.Visible = true;
                            lstDeseoDeClientes.Visible = true;
                        }

                    }
                }
                else
                {
                    lblCabina.Visible = true;
                    txtIdentificador.Visible = true;
                    btnIngersarCabina.Visible = true;
                    btnListarComputadoras.Enabled = false;
                    lstLlamadas.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No quedan mas clientes a los que atender");
                btnAsignar.Enabled = false;

            }
            //if(c1.Clientes.Count>0)
            //{
            //    c1.Clientes.Dequeue();
            //    rtbListarClientesDesatendidos.Text = c1.listarClientes();

            //}
            //else { MessageBox.Show("Ya no hay mas clientes :c");}
        }
        private void btnIngersarTelefono_Click(object sender, EventArgs e)
        {
            Identificador();
        }
        private void btnIngresarIdentificador_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < c1.Computadora.Count; i++)
            {
                
            }
        }
        private void btnTiempodePC_Click(object sender, EventArgs e)
        {
            txtComputadoraIdentificador.Visible = true;
            btnIngresarIdentificadorComputadora.Visible = true;
            lblComputadoraIdentificador.Visible = true;
            lstDeseoDeClientes.Visible = true;

            string tiempo;
            double tiempoDouble;
            tiempo = txtTiempoDePC.Text;
            if(tiempo == "")
            {
                MessageBox.Show("Reingrese el valor");
                btnAsignar.Enabled = false;
                btnListarComputadoras.Enabled = false;
                brnClientesDesatendidos.Enabled = false;
                btnFinalizacionDeServicio.Enabled = false;
                btnIngresarIdentificadorComputadora.Enabled = false;
            }else
            {
                tiempoDouble = Convert.ToDouble(tiempo);
                tiempoDouble = calcularTiempo(tiempoDouble);

                MessageBox.Show(tiempoDouble.ToString());
            }

        }
        public double calcularTiempo(double num)
        {
            if (num % 30 == 0 && num <= 240)
            {
                DateTime now = DateTime.Now;

                DateTime future = now.AddSeconds(num);

                TimeSpan interval = future - now;
               
                num = (double)interval.TotalSeconds;

            }
            else
            {
                MessageBox.Show("Ingrese invervalos de media hora, maximo 4 horas (420 minutos)");
            }
            return num;
        }
        private void btnNumeroTelefonico_Click(object sender, EventArgs e)
        {
            
            Llamada[] llamadas = new Llamada[]
          {
                new Llamada("Telephone",Llamada.ETipo.Teclado,"T00", false),
                new Llamada("Telephone",Llamada.ETipo.Teclado,"T01",false),
                new Llamada("Old-Telephone",Llamada.ETipo.Disco,"T02", false),
                new Llamada("Telephone",Llamada.ETipo.Teclado,"T03", false)
          };
            int i;
            for (i = 0; i < llamadas.Length; i++)
            {
                if (llamadas[i].Identificador == Identificador())
                {
                    cobro = llamadas[i].calcularCostoLlamada(txtNumeroTelefonico.Text);
                    break;
                }
            }
            if(cobro == 0)
            {
                MessageBox.Show("Error.Reingrese el numero... 12 caracteres(541159481872 como ejemplo).");
                btnAsignar.Enabled = false;
                btnIngersarCabina.Enabled = false;
                btnListarComputadoras.Enabled = false;
                brnClientesDesatendidos.Enabled = false;
                btnFinalizacionDeServicio.Enabled = false;
            }
            else
            {

            
                
                stp.Start();
                btnAsignar.Enabled = true;
                btnIngersarCabina.Enabled = true;
                btnListarComputadoras.Enabled = true;
                brnClientesDesatendidos.Enabled = true;
                btnFinalizacionDeServicio.Enabled = true;

                c1.Llamadas.ElementAt(i).Estado = true;
                lstLlamadas.Items.Clear();
                foreach (Llamada item in c1.Llamadas)
                {
                    lstLlamadas.Items.Add("Identificador: " + item.Identificador + " Cabina de tipo: " + item.Tipo + "Ocupada: " + item.Estado);
                }

                switch (cobro)
                {
                    case 2:
                        MessageBox.Show($"Llamada local. El cliente: {c1.Clientes.Peek().Nombre} a sido atendido");
                        break;
                    case 2.50:
                        MessageBox.Show($"Llamada larga distancia. El cliente: {c1.Clientes.Peek().Nombre} a sido atendido");
                        break;
                    case 5:
                        MessageBox.Show($"Llamada internacional El cliente: {c1.Clientes.Peek().Nombre} a sido atendido");
                        break;
                }

                c1.Clientes.Dequeue();
                rtbListarClientesDesatendidos.Text = c1.listarClientes();

                txtIdentificador.Visible = false;
                lblCabina.Visible = false;
                btnIngersarCabina.Visible = false;

                txtNumeroTelefonico.Visible = false;
                lblNumeroTelefonico.Visible = false;
                btnNumeroTelefonico.Visible = false;
                lstLlamadas.Visible = false;

            }

        }
        private void btnFinalizacionDeServicio_Click(object sender, EventArgs e)
        {

        }

        private void brnClientesDesatendidos_Click(object sender, EventArgs e)
        {
            rtbListarClientesDesatendidos.Text = c1.listarClientes();
        }

        private void btnListarComputadoras_Click(object sender, EventArgs e)
        {
            rtbListarComputadoras.Text = c1.listarCompus();
        }

        public string Identificador()
        {
            switch (txtIdentificador.Text)
            {
                case "T00":
                    if (c1.Llamadas.ElementAt(0).Estado == true)
                    {
                        MessageBox.Show("Cabina en uso. Asigne otra cabina");
                    }
                    else
                    {

                        lblNumeroTelefonico.Visible = true;
                        txtNumeroTelefonico.Visible = true;
                        btnNumeroTelefonico.Visible = true;

                    }
                    break;
                case "T01":
                    lblNumeroTelefonico.Visible = true;
                    txtNumeroTelefonico.Visible = true;
                    btnNumeroTelefonico.Visible = true;   
                    break;
                case "T02":
                    lblNumeroTelefonico.Visible = true;
                    txtNumeroTelefonico.Visible = true;
                    btnNumeroTelefonico.Visible = true;
                    break;
                case "T03":
                    lblNumeroTelefonico.Visible = true;
                    txtNumeroTelefonico.Visible = true;
                    btnNumeroTelefonico.Visible = true;
                    break;
                default:
                    MessageBox.Show("Error. No ingreso una cabina correcta");
                    break;
            }

            return txtIdentificador.Text;
        }

        public ElCiber CargarDatos()
        {
            Computadoras[] computadoras = new Computadoras[]
            {
            new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Nada },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Pentium4, "C00", false),
            new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Nada },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Ryzen9_7800x, "C01", true),
            new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Nada },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.PentiumGold, "C02", true),
            new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Nada },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Pentium3, "C03", false)
             };

            Llamada[] llamadas = new Llamada[]
          {
                new Llamada("Telephone",Llamada.ETipo.Teclado,"T00", false),
                new Llamada("Telephone",Llamada.ETipo.Teclado,"T01",false),
                new Llamada("Old-Telephone",Llamada.ETipo.Disco,"T02",false),
                new Llamada("Telephone",Llamada.ETipo.Teclado,"T03", false)
          };

            Clientes[] clientes = new Clientes[]
            {
                new Clientes("Luciano",43318194,"Pezza",20, false),
                new Clientes("Mauricio",37458921,"Cerizza",33, false),
                new Clientes("Estaban",39875321,"Quito",27, false),
                new Clientes("Lautaro",40035879,"Galarza",25, false),
                new Clientes("Troy",36548194,"McClure",45, false)
            };




            for (int i = 0; i < computadoras.Length; i++)
            {
                c1 += computadoras[i];
            }

            for (int i = 0; i < clientes.Length; i++)
            {
                c1 += clientes[i];
            }
            for (int i = 0; i < llamadas.Length; i++)
            {
                c1 += llamadas[i];
            }

            return c1;
        }


        public string valorRandomDeseoCliente()
        {
            Random random = new Random();
            int intRandom = random.Next(1, 5);
            string stringRandom = "";
            switch (intRandom)
            {
                case 1:
                    stringRandom = valorRandomHardware();
                    break;
                case 2:
                    stringRandom = valorRandomJuegos();
                    break;
                case 3:
                    stringRandom = valorRandomPerifericos();
                    break;
                case 4:
                    stringRandom = valorRandomSoftware();
                    break;
            }
            return stringRandom;
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
            string stringRandom = "";
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

      
    }
}
