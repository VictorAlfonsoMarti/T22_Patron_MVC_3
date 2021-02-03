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
    class Cientifico
    {
        public void Post(string DB, string tabla, string dni, string nomApels)
        {
            // método para crear tuplas

            // ATRIBUTOS
            string _dni;
            string _nomApels;

            // CONSTRUCTORES
            // si no hay nada, asignamos a null
            if (dni == "") { _dni = null; } else { _dni = dni; }
            if (nomApels == "") { _nomApels = null; } else { _nomApels = nomApels; }


            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connection.DB_Connexion_Open(DB);

            // codigoSQL
            string cadena = "INSERT INTO " + tabla + " VALUES ('" + _dni + "', '" + _nomApels + "')";

            try
            {
                // creamos el objeto con el codigo sql y la conexion
                SqlCommand comando = new SqlCommand(cadena, conexion);

                // ejecutamos el codigo sql en el objeto comando
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro insertado con éxito");
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
        }
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
        public DataTable Get_Id(string DB, string tabla, int dni)
        {
            // método para leer todas las tuplas por id 

            // ATRIBUTOS
            DataTable lista = new DataTable();

            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connection.DB_Connexion_Open(DB);
            // codigoSQL
            string cadena = "SELECT * FROM " + tabla + " WHERE dni = " + dni;

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
        public void Put(string DB, string tabla, string dni, string nomApels)
        {
            // método para actualizar tuplas por id

            // ATRIBUTOS
            string _dni;
            string _nomApels;


            // CONSTRUCTORES
            // si no hay nada, asignamos a null
            if (dni == "") { _dni = null; } else { _dni = dni; }
            if (nomApels == "") { _nomApels = null; } else { _nomApels = nomApels; }


            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connection.DB_Connexion_Open(DB);

            // codigoSQL
            string cadena = "UPDATE " + tabla + " SET dni = '" + _dni + "', nomApels = '" + _nomApels + "' WHERE dni = " + dni;

            try
            {
                // creamos el objeto con el codigo sql y la conexion
                SqlCommand comando = new SqlCommand(cadena, conexion);

                // ejecutamos el codigo sql en el objeto comando
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado con éxito");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // cerramos la conexión con la base de datos creada
                conexion.Close();
            }
        }
        public void Delete(string DB, string tabla, string dni)
        {
            // método para eliminar tuplas por id

            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connection.DB_Connexion_Open(DB);

            // codigoSQL
            string cadena = "DELETE FROM " + tabla + " WHERE dni = '" + dni + "'";

            try
            {
                // creamos el objeto con el codigo sql y la conexion
                SqlCommand comando = new SqlCommand(cadena, conexion);

                // ejecutamos el codigo sql en el objeto comando
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con éxito");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // cerramos la conexión con la base de datos creada
                conexion.Close();
            }
        }
    }
}
