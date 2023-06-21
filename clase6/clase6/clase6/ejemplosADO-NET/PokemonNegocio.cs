using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ejemplosADO_NET
{
    class PokemonNegocio
    {

        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conn = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                string servidor = ".\\SQLEXPRESS";      // servidor local, puede ir asi o con nombre NOTE_1\SQLEXPRESS
                string db = "POKEDEX_DB";               // nombre de la base de datos
                
                //armo el string de conexion, con usuario de sistema
                conn.ConnectionString = "server=" + servidor + "; database=" + db + "; integrated security = true";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Numero, Nombre, Descripcion FROM POKEMONS";
                comando.Connection = conn;

                conn.Open();        //abro conexion
                lector = comando.ExecuteReader();

                //posiciono fila y leo next
                while (lector.Read()) 
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Descripcion = (string) lector["Descripcion"];       //otra forma de ponerlo con cast

                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }

        }

    }
}
