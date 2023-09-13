using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class PokemonNegocio
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
                comando.CommandText = "SELECT P.Numero, Nombre, P.Descripcion, UrlImagen,"
                    + " E.Descripcion AS Tipo, D.Descripcion AS Debilidad " 
                    + "FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE P.IdTipo = E.Id AND D.Id = P.IdDebilidad";
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
                    aux.UrlImagen = lector.GetString (3);
                    aux.Tipo = new Elemento     //inicializo elemento nuevo con atributo leido
                    {
                        Descripcion = lector.GetString(4)
                    };
                    aux.Debilidad = new Elemento
                    {
                        Descripcion = lector.GetString(5)
                    };

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

        public void agregar(Pokemon p)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("INSERT INTO POKEMONS (Numero, Nombre, Descripcion, Activo) values (" + p.Numero +", ' "+ p.Nombre + "', '" + p.Descripcion + "', 1);");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
