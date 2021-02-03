using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T22_Patrón_MVC_3
{
    public partial class DB_Manager : Form
    {
        public DB_Manager()
        {
            InitializeComponent();
        }

        private void listBoxTabla_SelectedValueChanged(object sender, EventArgs e, string texto, DB_Manager dB_Manager)
        {
            // evento para ocultar los botones de editar, eliminar y actualizar registros si está seleccionada la tabla ASIGNADO_A
            // dado que es una tabla relacional con dos campos PK que dependen de la tabla Cientificos y Proyectos
            if (texto == "ASIGNADO_A")
            {
                dB_Manager.boton_editar.Hide();
                dB_Manager.boton_eliminar.Hide();
                dB_Manager.boton_actualizar.Hide();
            }
            else
            {
                dB_Manager.boton_editar.Show();
                dB_Manager.boton_eliminar.Show();
                dB_Manager.boton_actualizar.Show();
            }
        }
    }
}
