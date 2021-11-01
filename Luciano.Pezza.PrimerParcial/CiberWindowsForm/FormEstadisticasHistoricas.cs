using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ciber;
namespace CiberWindowsForm
{
    public partial class FormEstadisticasHistoricas : Form
    {
        ElCiber cFinal;
        bool compuLibre;
        public FormEstadisticasHistoricas(ElCiber c1)
        {
            InitializeComponent();
            cFinal = c1;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cFinal.Computadora.Count; i++)
            {
                if(cFinal.Computadora.ElementAt(i).Identificador==txtIdentificadorFinalizante.Text)
                {
                    if(compuLibre == true)
                    {
                        cFinal.Computadora[i].TiempoDeUsoLibre = cFinal.Computadora[i].Temporizador.Elapsed;
                        cFinal.Computadora[i].Temporizador.Stop();

                        cFinal.Computadora[i].Cobro *= Convert.ToDouble(cFinal.Computadora[i].TiempoDeUsoLibre);

                        MessageBox.Show("Test"+ cFinal.Computadora[i].Cobro);
                    }
                    else
                    {

                    }


                }
                if(cFinal.Llamadas.ElementAt(i).Identificador==txtIdentificadorFinalizante.Text)
                {

                }
            }
        }

        private void FormEstadisticasHistoricas_Load(object sender, EventArgs e)
        {
            foreach  (Computadoras compusEnUso in cFinal.Computadora)
            {
                if(compusEnUso.Estado==true)
                {
                    if(compusEnUso.ComputadoraLibre==true)
                    {
                        lstIdentificadoresFinales.Items.Add("Computadora Libre: " + compusEnUso.Identificador);
                        compuLibre = true;
                    }
                    else
                    {
                        lstIdentificadoresFinales.Items.Add("Computadora no libre: " + compusEnUso.Identificador);
                        compuLibre = false;
                    }
                }
            } 
            
            foreach  (Telefono telefonoEnUso in cFinal.Llamadas)
            {
                if(telefonoEnUso.Estado==true)
                {
                    lstIdentificadoresFinales.Items.Add("Cabina: "+telefonoEnUso.Identificador);
                }
            }


            
        }
    }
}
