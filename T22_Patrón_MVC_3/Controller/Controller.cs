using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T22_Patrón_MVC_3.Model;
using System.Windows.Forms;
using T22_Patrón_MVC_3.View;
using T22_Patrón_MVC_3.Model.DB_Connection;
using System.Data.SqlClient;
using System.Data;

namespace T22_Patrón_MVC_3.Controller
{
    class Controller
    {
        public void dB_Manager_Controller(DB_Manager dB_Manager)
        {
            // Controlador principal, aplica los eventos en los botones y ejecuta la ventana.


            //EVENTOS
            dB_Manager.buttonListarTablas.Click += (sender, EventArgs) => { textBoxBD_TextChanged(sender, EventArgs, dB_Manager, dB_Manager.textBoxBD.Text); };
            dB_Manager.boton_verTabla.Click += (sender, EventArgs) => { verTabla_Click(sender, EventArgs, dB_Manager.textBoxBD.Text, Convert.ToString(dB_Manager.listBoxTabla.SelectedItem), dB_Manager); };
            dB_Manager.boton_verRegistros.Click += (sender, EventArgs) => { verRegistros_Click(sender, EventArgs, dB_Manager.textBoxBD.Text, Convert.ToString(dB_Manager.listBoxTabla.SelectedItem), dB_Manager); };
            dB_Manager.boton_actualizar.Click += (sender, EventArgs) => { insertar_Click(sender, EventArgs, dB_Manager.textBoxBD.Text, Convert.ToString(dB_Manager.listBoxTabla.SelectedItem), dB_Manager); };
            dB_Manager.boton_eliminar.Click += (sender, EventArgs) => { eliminar_Click(sender, EventArgs, dB_Manager.textBoxBD.Text, Convert.ToString(dB_Manager.listBoxTabla.SelectedItem), dB_Manager); };
            dB_Manager.boton_editar.Click += (sender, EventArgs) => { editarRegistro_Click(sender, EventArgs, dB_Manager.textBoxBD.Text, Convert.ToString(dB_Manager.listBoxTabla.SelectedItem), dB_Manager); };

            // ejecutamos y abrimos la ventana del programa
            Application.Run(dB_Manager);
        }


        public void verTabla_Click(object sender, EventArgs e, string DB, string tabla, DB_Manager dB_Manager)
        {
            // botón para ver toda la tabla

            // ATRIBUTOS
            Cientifico conexion = new Cientifico(); // conexion al Cientifico para usar su metodo para printar
            DataTable datos = conexion.Get(DB, tabla); // guardamos los datos de la BD en un objeto DataTable
            dB_Manager.tablas.DataSource = datos;
        }

        private void verRegistros_Click(object sender, EventArgs e, string DB, string tabla, DB_Manager dB_Manager)
        {
            // botón para ver registros especificos           
            
            switch (tabla)
            {
                case "CIENTIFICOS":
                    RegistroCientifico cientifico = new RegistroCientifico();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    cientifico.panel_mostrar.Visible = true;
                    // asignamos evento al boton enviar
                    cientifico.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Cientifico(senderB, EventArgs, cientifico, "ver", DB, tabla, dB_Manager); };
                    cientifico.Show();
                    break;
                case "PROYECTO":
                    RegistroProyecto proyecto = new RegistroProyecto();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    proyecto.panel_mostrar.Visible = true;
                    // asignamos evento al boton enviar
                    proyecto.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Proyecto(senderB, EventArgs, proyecto, "ver", DB, tabla, dB_Manager); };
                    proyecto.Show();
                    break;
                case "ASIGNADO_A":
                    RegistroAsignado_A asignado_A = new RegistroAsignado_A();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    asignado_A.panel_mostrar.Visible = true;
                    // asignamos evento al boton enviar
                    asignado_A.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Asignado_A(senderB, EventArgs, asignado_A, "ver", DB, tabla, dB_Manager); };
                    asignado_A.Show();
                    break;
            }

            // actualizamos la tabla
            verTabla_Click(sender, e, DB, tabla, dB_Manager);
        }

        private void editarRegistro_Click(object sender, EventArgs e, string DB, string tabla, DB_Manager dB_Manager)
        {
            // botón para actualizar registros

            switch (tabla)
            {
                case "CIENTIFICOS":
                    RegistroCientifico cientifico = new RegistroCientifico();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    cientifico.panelEditarID.Visible = true;
                    // asignamos evento al boton enviar
                    cientifico.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Cientifico(senderB, EventArgs, cientifico, "editar", DB, tabla, dB_Manager); };
                    cientifico.Show();
                    break;
                case "PROYECTO":
                    RegistroProyecto proyecto = new RegistroProyecto();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    proyecto.panelEditarID.Visible = true;
                    // asignamos evento al boton enviar
                    proyecto.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Proyecto(senderB, EventArgs, proyecto, "editar", DB, tabla, dB_Manager); };
                    proyecto.Show();
                    break;
            }

            // actualizamos la tabla
            verTabla_Click(sender, e, DB, tabla, dB_Manager);
        }

        private void insertar_Click(object sender, EventArgs e, string DB, string tabla, DB_Manager dB_Manager)
        {
            // botón para actualizar registros

            switch (tabla)
            {
                case "CIENTIFICOS":
                    RegistroCientifico cientifico = new RegistroCientifico();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    cientifico.panel_anadir.Visible = true;
                    // asignamos evento al boton enviar
                    cientifico.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Cientifico(senderB, EventArgs, cientifico, "insertar", DB, tabla, dB_Manager); };
                    cientifico.Show();
                    break;
                case "PROYECTO":
                    RegistroProyecto proyecto = new RegistroProyecto();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    proyecto.panel_anadir.Visible = true;
                    // asignamos evento al boton enviar
                    proyecto.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Proyecto(senderB, EventArgs, proyecto, "insertar", DB, tabla, dB_Manager); };
                    proyecto.Show();
                    break;
            }

            // actualizamos la tabla
            verTabla_Click(sender, e, DB, tabla, dB_Manager);
        }

        private void eliminar_Click(object sender, EventArgs e, string DB, string tabla, DB_Manager dB_Manager)
        {
            // botón para eliminar registros

            switch (tabla)
            {
                case "CIENTIFICOS":
                    RegistroCientifico cientifico = new RegistroCientifico();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    cientifico.panel_eliminar.Visible = true;
                    // asignamos evento al boton enviar
                    cientifico.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Cientifico(senderB, EventArgs, cientifico, "eliminar", DB, tabla, dB_Manager); };
                    cientifico.Show();
                    break;
                case "PROYECTO":
                    RegistroProyecto proyecto = new RegistroProyecto();
                    // asignamos la vista de mostrar y ejecutamos la ventana 
                    proyecto.panel_eliminar.Visible = true;
                    // asignamos evento al boton enviar
                    proyecto.boton_enviar.Click += (senderB, EventArgs) => { enviar_Click_Proyecto(senderB, EventArgs, proyecto, "eliminar", DB, tabla, dB_Manager); };
                    proyecto.Show();
                    break;
            }

            // actualizamos la tabla
            verTabla_Click(sender, e, DB, tabla, dB_Manager);

        }

        private void enviar_Click_Cientifico(object sender, EventArgs e, RegistroCientifico registro, string accion, string DB, string tabla, DB_Manager dB_Manager)
        {
            // botón para llamar a diferentes métodos dependiendo del evento que quieran hacer

            // ATRIBUTOS
            Cientifico Cientifico = new Cientifico();
            DataTable datos;

            switch (accion)
            {
                case "ver":
                    datos = Cientifico.Get_Id(DB, tabla, Convert.ToInt32(registro.textBoxMostrarID.Text)); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos; // actualizamos la tabla
                    break;
                case "insertar":
                    Cientifico.Post(DB, tabla, registro.textBoxNomApels.Text, registro.textBoxDNI.Text);
                    datos = Cientifico.Get(DB, tabla); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos;// actualizamos la tabla
                    break;
                case "editar":
                    Cientifico.Put(DB, tabla, registro.textBoxEditarID.Text, registro.textBoxEditarNomApels.Text);
                    datos = Cientifico.Get(DB, tabla); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos;// actualizamos la tabla
                    break;
                case "eliminar":
                    Cientifico.Delete(DB, tabla, registro.textBox_EliminarID.Text);
                    datos = Cientifico.Get(DB, tabla); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos;// actualizamos la tabla
                    break;
            }
        }

        private void enviar_Click_Proyecto(object sender, EventArgs e, RegistroProyecto registro, string accion, string DB, string tabla, DB_Manager dB_Manager)
        {
            // botón para llamar a diferentes métodos dependiendo del evento que quieran hacer

            // ATRIBUTOS
            Proyecto proyecto = new Proyecto();
            DataTable datos;

            switch (accion)
            {
                case "ver":
                    datos = proyecto.Get_Id(DB, tabla, registro.textBoxMostrarID.Text); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos; // actualizamos la tabla
                    break;
                case "insertar":
                    proyecto.Post(DB, tabla, registro.textBoxAnadriID.Text, registro.textBoxAnadirNombre.Text, Convert.ToInt32(registro.textBoxAnadirHoras.Text));
                    datos = proyecto.Get(DB, tabla); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos;// actualizamos la tabla
                    break;
                case "editar":
                    proyecto.Put(DB, tabla, registro.textBoxEditarID.Text, registro.textBoxEditarNombre.Text, Convert.ToInt32(registro.textBoxEditarHoras.Text));
                    datos = proyecto.Get(DB, tabla); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos;// actualizamos la tabla
                    break;
                case "eliminar":
                    proyecto.Delete(DB, tabla, Convert.ToInt32(registro.textBox_EliminarID.Text));
                    datos = proyecto.Get(DB, tabla); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos;// actualizamos la tabla
                    break;
            }
        }

        private void enviar_Click_Asignado_A(object sender, EventArgs e, RegistroAsignado_A registro, string accion, string DB, string tabla, DB_Manager dB_Manager)
        {
            // botón para llamar a diferentes métodos dependiendo del evento que quieran hacer

            // ATRIBUTOS
            Asignado_A asignado_A = new Asignado_A();
            DataTable datos;

            switch (accion)
            {
                case "ver":
                    datos = asignado_A.Get_Id(DB, tabla, registro.textBoxMostrarDNI.Text, registro.textBoxMostrarID.Text); // guardamos los datos de la BD en un objeto DataTable
                    dB_Manager.tablas.DataSource = datos; // actualizamos la tabla
                    break;
            }
        }

        private void textBoxBD_TextChanged(object sender, EventArgs ev, DB_Manager dB_Manager, string dB_Name)
        {
            // llena el cuadro de tablas con las tablas de una bd

            SqlConnection conexion = DB_Connection.DB_Connexion_Open(dB_Name);

            try
            {
                // recogemos los nombres de las tablas en un objeto
                DataTable dt = conexion.GetSchema("Tables");

                // eliminamos el contenido de la lista
                dB_Manager.listBoxTabla.Items.Clear();

                // por cada nombre en el objeto
                foreach (DataRow row in dt.Rows)
                {
                    // printamos
                    dB_Manager.listBoxTabla.Items.Add((string)row[2]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
