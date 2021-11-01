using Ciber;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;
namespace CiberWindowsForm
{
    public partial class FormPrueba : Form
    {
        ElCiber c2;
        public FormPrueba(ElCiber c1)
        {
            InitializeComponent();
            c2 = c1;
           
        }

        private void FormPrueba_Load(object sender, EventArgs e)
        {
            c2.Computadora.ElementAt(3).Estado = true;
        }
    }
}
