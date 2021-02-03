using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T22_Patrón_MVC_3.Model
{
    class Asignado_A
    {
        public DataTable Get(string DB, string tabla)
        {
            // método para leer todas las tuplas 

            //ATRIBUTOS
            DataTable lista = new DataTable();

            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connection.DB_Connexion_Open(DB);

            // codigoSQL
            string cadena = "SELECT * FROM " + tabla;

            try
            {
                // ejecutamos el codigo sql con la conexion
                SqlDataAdapter codigo = new SqlDataAdapter(cadena, conexion);

                // llenamos la tabla con la devolucion
                codigo.Fill(lista);
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                // cerramos la conexión con la base de datos creada
                conexion.Close();
            }

            // retornamos la lista
            return lista;

        }
        public DataTable Get_Id(string DB, string tabla, string dni, string id)
        {
            // método para leer todas las tuplas por id 

            // ATRIBUTOS
            DataTable lista = new DataTable();

            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connection.DB_Connexion_Open(DB);
            // codigoSQL
            string cadena = "SELECT * FROM " + tabla + " WHERE Cientifico = " + dni + " AND Proyecto = '" + id + "'";

            try
            {
                // ejecutamos el codigo sql con la conexion
                SqlDataAdapter codigo = new SqlDataAdapter(cadena, conexion);

                // llenamos la tabla con la devolucion
                codigo.Fill(lista);
            }
            catch (Exception e)
            {
                MessageBox.Show(Convert.ToString(e));
            }
            finally
            {
                // cerramos la conexión con la base de datos creada
                conexion.Close();
            }

            // retornamos la lista
            return lista;

        }
    }
}