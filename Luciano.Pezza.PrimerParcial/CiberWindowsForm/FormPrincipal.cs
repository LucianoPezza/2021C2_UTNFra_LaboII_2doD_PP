using Ciber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CiberWindowsForm
{

    public partial class FormPrincipal : Form
    {
        ElCiber c1 = new ElCiber();
        string deseoRandomDeCliente;
        int auxRetornoDeseoRandom;


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            c1 = CargarDatos();

            auxRetornoDeseoRandom = valorRandomDeseoCliente();

            lstDeseoDeClientes.Items.Add("El cliente " + c1.Clientes.Peek().Nombre + " Desea: " + deseoRandomDeCliente);

            foreach (Telefono item in c1.Llamadas)
            {
                lstLlamadas.Items.Add("Identificador: " + item.Identificador + " Cabina de tipo: " + item.Tipo + "Ocupada: " + item.Estado);
            }
            lblInformacionPersonal.Text = "Pezza Luciano" + " " + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
            ocultar();
        }
        public void ocultar()
        {
            txtIdentificador.Visible = false;
            lblCabina.Visible = false;
            btnIngersarCabina.Visible = false;

            txtNumeroTelefonico.Visible = false;
            lblNumeroTelefonico.Visible = false;
            btnNumeroTelefonico.Visible = false;
            lstLlamadas.Visible = false;


            txtComputadoraIdentificador.Visible = false;
            btnComputadoraIdentificador.Visible = false;
            lblComputadoraIdentificador.Visible = false;
            lstDeseoDeClientes.Visible = false;

            btnTiempodePC.Visible = false;
            txtTiempoDePC.Visible = false;
            lblTiempoDeLaPc.Visible = false;
        }
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int contadorMaquinasDisponibles = 0;
            if (c1.Clientes.Count > 0)
            {
                DialogResult dialogo = MessageBox.Show("Quiere asignar una cabina?", "Asignar Cabina", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.No)
                {

                    dialogo = MessageBox.Show("Quiere asignar una Computadora?", "Asignar PC", MessageBoxButtons.YesNo);
                    if (dialogo == DialogResult.Yes)
                    {
                        rtbListarComputadoras.Text = c1.listarCompus();

                        foreach (Computadoras computadoras in c1.Computadora)
                        {
                            if (computadoras.Estado == false)
                            {

                                btnAsignar.Enabled = false;
                                btnListarComputadoras.Enabled = false;
                                btnClientesDesatendidos.Enabled = false;
                                btnFinalizacionDeServicio.Enabled = false;

                                txtComputadoraIdentificador.Visible = true;
                                btnComputadoraIdentificador.Visible = true;
                                lblComputadoraIdentificador.Visible = true;

                                auxRetornoDeseoRandom = valorRandomDeseoCliente();
                                lstDeseoDeClientes.Visible = true;


                                contadorMaquinasDisponibles++;
                                break;
                            }
                        }
                        if (contadorMaquinasDisponibles == 0)
                        {
                            MessageBox.Show("No hay mas computadoras disponibles");
                        }

                    }
                }
                else
                {
                    foreach (Telefono telefonos in c1.Llamadas)
                    {
                        if (telefonos.Estado == false)
                        {
                            lblCabina.Visible = true;
                            txtIdentificador.Visible = true;
                            btnIngersarCabina.Visible = true;
                            btnListarComputadoras.Enabled = false;
                            lstLlamadas.Visible = true;
                            btnAsignar.Enabled = false;
                            contadorMaquinasDisponibles++;
                            break;
                        }
                    }
                    if (contadorMaquinasDisponibles == 0)
                    {
                        MessageBox.Show("No hay mas cabinas disponibles");
                    }


                }
            }
            else
            {
                MessageBox.Show("No quedan mas clientes a los que atender");
                btnAsignar.Enabled = false;

            }
        }

        private void btnIngresarIdentificador_Click(object sender, EventArgs e)
        {


            int contadorAux = recorrerEspecificacionesDePc();

            if (!(IdentificadorComputadoras().Contains(" ")) && contadorAux != -1)
            {
                DialogResult dialogo = MessageBox.Show("Quiere una pc Libre?", "Opcion libre", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.No)
                {
                    lblTiempoDeLaPc.Visible = true;
                    txtTiempoDePC.Visible = true;
                    btnTiempodePC.Visible = true;
                }
                else
                {
                    for (int i = 0; i < c1.Computadora.Count; i++)
                    {
                        if (c1.Computadora.ElementAt(i).Identificador == IdentificadorComputadoras())
                        {

                            c1.Computadora.ElementAt(i).Estado = true;
                            c1.Computadora.ElementAt(i).Temporizador.Start();
                            c1.Computadora.ElementAt(i).ComputadoraLibre = true;


                            btnAsignar.Enabled = true;
                            btnListarComputadoras.Enabled = true;
                            btnClientesDesatendidos.Enabled = true;
                            btnFinalizacionDeServicio.Enabled = true;

                            c1.Clientes.Dequeue();
                            rtbListarClientesDesatendidos.Text = c1.listarClientes();
                            rtbListarComputadoras.Text = c1.listarCompus();
                            ocultar();
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Esa pc no tenia lo que queria el cliente");
            }
        }

        private int recorrerEspecificacionesDePc()
        {
            int contadorAux = -1;

            for (int i = 0; i < c1.Computadora.Count; i++)
            {
                if (c1.Computadora.ElementAt(i).Identificador == IdentificadorComputadoras())
                {


                    switch (auxRetornoDeseoRandom)
                    {
                        case 1:
                            if (c1.Computadora[i].Hardware.ToString() == deseoRandomDeCliente)
                            {
                                contadorAux = 1;
                            }
                            break;
                        case 2:
                            for (int j = 0; j < c1.Computadora[i].Juegos.Count; j++)
                            {
                                if (c1.Computadora[i].Juegos[j].ToString() == deseoRandomDeCliente)
                                {
                                    contadorAux = 1;
                                    break;
                                }
                            }
                            break;
                        case 3:
                            for (int p = 0; p < c1.Computadora[i].Perifericos.Count; p++)
                            {
                                if (c1.Computadora[i].Perifericos[p].ToString() == deseoRandomDeCliente)
                                {
                                    contadorAux = 1;
                                    break;
                                }

                            }
                            break;
                        case 4:
                            for (int s = 0; s < c1.Computadora[i].Software.Count; s++)
                            {
                                if (c1.Computadora[i].Software[s].ToString() == deseoRandomDeCliente)
                                {
                                    contadorAux = 1;
                                    break;
                                }
                            }
                            break;
                    }
                }
            }
            return contadorAux;
        }


        private void btnTiempodePC_Click(object sender, EventArgs e)
        {

            string tiempo;
            int auxTiempo = 0;
            tiempo = txtTiempoDePC.Text;
            bool aux = int.TryParse(tiempo, out auxTiempo);
            if (!aux)
            {
                MessageBox.Show("Error. Ingrese invervalos de media hora");
                btnAsignar.Enabled = false;
                btnListarComputadoras.Enabled = false;
                btnClientesDesatendidos.Enabled = false;
                btnFinalizacionDeServicio.Enabled = false;
                btnComputadoraIdentificador.Enabled = false;
            }
            else
            {
                for (int i = 0; i < c1.Computadora.Count; i++)
                {
                    if (c1.Computadora.ElementAt(i).Identificador == IdentificadorComputadoras())
                    {
                        if (auxTiempo % 30 == 0 && auxTiempo <= 480)
                        {
                            c1.Computadora.ElementAt(i).TiempoDeUso = auxTiempo;
                            c1.Computadora.ElementAt(i).Cobro *= c1.Computadora.ElementAt(i).TiempoDeUso;
                            c1.Computadora.ElementAt(i).Estado = true;
                            c1.Computadora.ElementAt(i).ComputadoraLibre = true;

                            MessageBox.Show(c1.Computadora.ElementAt(i).Cobro.ToString());

                            c1.Clientes.Dequeue();
                            rtbListarClientesDesatendidos.Text = c1.listarClientes();

                            btnAsignar.Enabled = true;
                            btnListarComputadoras.Enabled = true;
                            btnClientesDesatendidos.Enabled = true;
                            btnFinalizacionDeServicio.Enabled = true;
                            btnComputadoraIdentificador.Enabled = true;
                            btnAsignar.Enabled = true;
                            btnFinalizacionDeServicio.Enabled = true;
                            ocultar();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Error.Ingrese invervalos de media hora");
                            break;
                        }
                    }
                }
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
            int i;
            for (i = 0; i < c1.Llamadas.Count; i++)
            {
                if (c1.Llamadas.ElementAt(i).Identificador == Identificador())
                {
                    c1.Llamadas.ElementAt(i).Costo = c1.Llamadas.ElementAt(i).calcularCostoLlamada(txtNumeroTelefonico.Text);
                    break;
                }
            }
            if (c1.Llamadas.ElementAt(i).Costo == 0)
            {
                MessageBox.Show("Error.Reingrese el numero... 12 caracteres(541159481872 como ejemplo).");
                btnAsignar.Enabled = false;
                btnIngersarCabina.Enabled = false;
                btnListarComputadoras.Enabled = false;
                btnClientesDesatendidos.Enabled = false;
                btnFinalizacionDeServicio.Enabled = false;
            }
            else
            {

                btnAsignar.Enabled = true;
                btnIngersarCabina.Enabled = true;
                btnListarComputadoras.Enabled = true;
                btnClientesDesatendidos.Enabled = true;
                btnFinalizacionDeServicio.Enabled = true;

                c1.Llamadas.ElementAt(i).Estado = true;
                lstLlamadas.Items.Clear();
                foreach (Telefono item in c1.Llamadas)
                {
                    lstLlamadas.Items.Add("Identificador: " + item.Identificador + " Cabina de tipo: " + item.Tipo + "Ocupada: " + item.Estado);
                }

                switch (c1.Llamadas.ElementAt(i).Costo)
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
                c1.Llamadas.ElementAt(i).Temporizador.Start();
                txtIdentificador.Visible = false;
                lblCabina.Visible = false;
                btnIngersarCabina.Visible = false;
                txtNumeroTelefonico.Visible = false;
                lblNumeroTelefonico.Visible = false;
                btnNumeroTelefonico.Visible = false;
                lstLlamadas.Visible = false;
                btnFinalizacionDeServicio.Enabled = true;
            }


        }

        private void btnFinalizacionDeServicio_Click(object sender, EventArgs e)
        {
            FormEstadisticasHistoricas frmEH = new FormEstadisticasHistoricas(c1);
            frmEH.ShowDialog();
        }

        private void brnClientesDesatendidos_Click(object sender, EventArgs e)
        {
            rtbListarClientesDesatendidos.Text = c1.listarClientes();
        }

        private void btnListarComputadoras_Click(object sender, EventArgs e)
        {
            rtbListarComputadoras.Text = c1.listarCompus();
            //foreach (Computadoras item in c1.Computadora)
            //{
            //    if(item.Estado==true)
            //    {
            //        item.TiempoDeUsoLibre = item.Temporizador.Elapsed;
            //        item.Temporizador.Stop();
            //        MessageBox.Show(item.TiempoDeUsoLibre.ToString());
            //    }
            //}
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
                    if (c1.Llamadas.ElementAt(1).Estado == true)
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
                case "T02":
                    if (c1.Llamadas.ElementAt(2).Estado == true)
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
                case "T03":
                    if (c1.Llamadas.ElementAt(3).Estado == true)
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
                default:
                    MessageBox.Show("Error. No ingreso una cabina correcta");
                    break;
            }

            return txtIdentificador.Text;
        }
        public string IdentificadorComputadoras()
        {
            string auxstr = " ";
            switch (txtComputadoraIdentificador.Text)
            {
                case "C00":
                    if (c1.Computadora.ElementAt(0).Estado == true)
                    {
                        MessageBox.Show("Computadora en uso. Asigne otra");
                    }
                    else
                    {
                        auxstr = txtComputadoraIdentificador.Text;
                    }
                    break;
                case "C01":
                    if (c1.Computadora.ElementAt(1).Estado == true)
                    {
                        MessageBox.Show("Computadora en uso. Asigne otra");
                    }
                    else
                    {
                        auxstr = txtComputadoraIdentificador.Text;
                    }
                    break;
                case "C02":
                    if (c1.Computadora.ElementAt(2).Estado == true)
                    {
                        MessageBox.Show("Computadora en uso. Asigne otra");
                    }
                    else
                    {
                        auxstr = txtComputadoraIdentificador.Text;
                    }
                    break;
                case "C03":
                    if (c1.Computadora.ElementAt(3).Estado == true)
                    {
                        MessageBox.Show("Computadora en uso. Asigne otra");
                    }
                    else
                    {
                        auxstr = txtComputadoraIdentificador.Text;
                    }
                    break;
                default:
                    MessageBox.Show("Error. No ingreso una computadora correcta");
                    break;
            }

            return auxstr;
        }
        public ElCiber CargarDatos()
        {
            Computadoras[] computadoras = new Computadoras[]
            {
            new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Nero, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Auriculares },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.AgeOfEmpiresII, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.MUHOT },
            Computadoras.EHardware.Pentium4, "C00", false),
            new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Office, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Nero },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Camara },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.AgeOfEmpiresII, Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.Ryzen9_7800x, "C01", false),
            new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Office, Computadoras.ESoftware.Ares, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Nada },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.MUHOT, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.AgeOfEmpiresII, Computadoras.EJuegosDisponibles.WarcraftIII },
            Computadoras.EHardware.PentiumGold, "C02", false),
            new Computadoras(new List<Computadoras.ESoftware>() { Computadoras.ESoftware.Ares, Computadoras.ESoftware.Icq, Computadoras.ESoftware.Messenger },
            new List<Computadoras.EPerifericosDisponibles>() { Computadoras.EPerifericosDisponibles.Microfono },
            new List<Computadoras.EJuegosDisponibles>() { Computadoras.EJuegosDisponibles.DiabloII, Computadoras.EJuegosDisponibles.CounterStrike, Computadoras.EJuegosDisponibles.MUHOT, Computadoras.EJuegosDisponibles.LinageII },
            Computadoras.EHardware.Pentium3, "C03", false)
             };

            Telefono[] llamadas = new Telefono[]
          {
                new Telefono("Telephone",Telefono.ETipo.Teclado,"T00", false),
                new Telefono("Telephone",Telefono.ETipo.Teclado,"T01",false),
                new Telefono("Old-Telephone",Telefono.ETipo.Disco,"T02",false),
                new Telefono("Telephone",Telefono.ETipo.Teclado,"T03", false)
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


        public int valorRandomDeseoCliente()
        {
            Random random = new Random();
            int intRandom = random.Next(1, 5);
            int num = 0;
            switch (intRandom)
            {
                case 1:
                    deseoRandomDeCliente = valorRandomHardware();
                    num = 1;
                    break;
                case 2:
                    deseoRandomDeCliente = valorRandomJuegos();
                    num = 2;
                    break;
                case 3:
                    deseoRandomDeCliente = valorRandomPerifericos();
                    num = 3;
                    break;
                case 4:
                    deseoRandomDeCliente = valorRandomSoftware();
                    num = 4;
                    break;
            }
            return num;
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
            int intRandom = random.Next(1, 4);
            string auxString = "";
            switch (intRandom)
            {
                case 1:
                    auxString = "Auriculares";
                    break;
                case 2:
                    auxString = "Camara";
                    break;
                case 3:
                    auxString = "Microfono";
                    break;
            }
            return auxString;
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

        private void btnIngersarCabina_Click(object sender, EventArgs e)
        {
            Identificador();
        }

        private void rtbListarComputadoras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
