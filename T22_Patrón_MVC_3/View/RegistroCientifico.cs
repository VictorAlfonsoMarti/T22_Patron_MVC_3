using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T22_Patrón_MVC_3.View
{
    public partial class RegistroCientifico : Form
    {
        public RegistroCientifico()
        {
            InitializeComponent();
        }
        private void boton_salir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
