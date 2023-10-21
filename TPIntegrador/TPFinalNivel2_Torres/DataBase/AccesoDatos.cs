using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class AccesoDatos
    {
        private SqlConnection conn;
        private SqlCommand comando;
        private SqlDataReader reader;
        //acceso a handler
        public SqlDataReader Reader { get { return reader; } }

        public AccesoDatos()
        {
            //carga de server y DDBB
            string server = ".\\SQLEXPRESS";
            string db = "CATALOGO_DB";

            this.conn = new SqlConnection("server=" + server + "; database=" + db +
                "; integrated security = true");
            this.comando = new SqlCommand();
        } 

        //cargar el comando para una consulta
        public void setConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        //setear parametros para inyeccion de codigo
        public void setParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        //ejecuta consulta y devuelve el resultado de la query en un handler
        public void ejecutarQuery()
        {
            comando.Connection = conn;
            try
            {
                conn.Open();
                reader = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //ejecuta consulta que no devuelve handler
        public void ejecutarAccion()
        {
            comando.Connection = conn;
            try
            {
                conn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //cierra conexion
        public void cerrarConexion()
        {
            if (reader != null)
                reader.Close();
            conn.Close();
        }
    }
}
