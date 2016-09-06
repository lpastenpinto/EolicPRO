using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace OptimizacionVientos

{
    class Conexion
    {
        SqlConnection conexionBD;
        SqlCommand query = null;

        //Constructor que conecta a la base de datos
        public Conexion()
        {

            string cadenaDeConexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|Vientos.mdf;User Instance=true";
            try
            {
                conexionBD = new SqlConnection(cadenaDeConexion);
            }
            catch (Exception e)
            {
                System.Console.Write("error" + e);
            }
        }

        //Ejecuta una consulta
        public void consultaSQL(String consulta)
        {
            query = new SqlCommand(consulta, conexionBD);
        }

        //Abre la base de datos
        public void abrirDataBase()
        {
            conexionBD.Open();
        }

        //Cierra la base de datos
        public void cerrarDataBase()
        {
            conexionBD.Close();
        }

        //Ejecutar la consulta
        public SqlDataReader ejecutarQuery()
        {
            return query.ExecuteReader();
        }

        //Inserta datos en la base de datos
        public void insertarDatos(String Data)
        {
            
            query = new SqlCommand(Data, conexionBD);

            conexionBD.Open();
            int test = query.ExecuteNonQuery();
            conexionBD.Close();
            MessageBox.Show("test:" + test);
        }
    }
}

