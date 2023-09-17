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
                comando.CommandText = "SELECT P.Numero, Nombre, P.Descripcion, UrlImagen, "
                    + "E.Descripcion AS Tipo, D.Descripcion AS Debilidad, P.IdTipo, P.IdDebilidad, P.Id "
                    + "FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE P.IdTipo = E.Id AND "
                    + "D.Id = P.IdDebilidad AND P.Activo = 1;";
                comando.Connection = conn;

                conn.Open();        //abro conexion
                lector = comando.ExecuteReader();

                //posiciono fila y leo next
                while (lector.Read()) 
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Descripcion = (string) lector["Descripcion"];       //otra forma de ponerlo con cast

                    //if(!lector.IsDBNull(lector.GetOrdinal("UrlImagen"))) esta es una forma
                    //    aux.UrlImagen = lector.GetString (3);
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = lector.GetString(3);
                    aux.Tipo = new Elemento     //inicializo elemento nuevo con atributo leido
                    {
                        Descripcion = lector.GetString(4)
                    };
                    aux.Tipo.id = (int) lector["IdTipo"];
                    aux.Debilidad = new Elemento
                    {
                        Descripcion = lector.GetString(5)
                    };
                    aux.Debilidad.id = (int)lector["IdDebilidad"];

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
                datos.setConsulta("INSERT INTO POKEMONS (Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) values (" + p.Numero +", ' "+ p.Nombre + "', '" + p.Descripcion + "', @urlImagen, @idTipo, @idDebilidad, 1);");
                datos.setearParametro("@idTipo", p.Tipo.id);
                datos.setearParametro("@idDebilidad", p.Debilidad.id);
                datos.setearParametro("@urlImagen", p.UrlImagen);
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

        public void modificar (Pokemon p)
        {
            AccesoDatos datos = new AccesoDatos ();
            try
            {
                datos.setConsulta("UPDATE POKEMONS SET Numero = @numero, Nombre = @nombre, Descripcion = @descripcion, UrlImagen = @urlImagen, IdTipo = @idTipo, IdDebilidad = @idDebilidad WHERE Id = @id;");
                datos.setearParametro("@numero", p.Numero);
                datos.setearParametro("@nombre", p.Nombre);
                datos.setearParametro("@descripcion", p.Descripcion);
                datos.setearParametro("@urlImagen", p.UrlImagen);
                datos.setearParametro("@idTipo", p.Tipo.id);
                datos.setearParametro("@idDebilidad", p.Debilidad.id);
                datos.setearParametro("@id", p.Id);

                datos.ejecutarAccion ();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion ();
            }
        }

        public void eliminar (int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("DELETE from POKEMONS where Id = @Id;");
                datos.setearParametro ("@Id", id);
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

        public void eliminarLogico (int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("UPDATE POKEMONS SET Activo = 0 WHERE Id = @Id;");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            filtro = filtro.Trim();
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "SELECT P.Numero, Nombre, P.Descripcion, UrlImagen, "
                    + "E.Descripcion AS Tipo, D.Descripcion AS Debilidad, P.IdTipo, P.IdDebilidad, P.Id "
                    + "FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE P.IdTipo = E.Id AND "
                    + "D.Id = P.IdDebilidad AND P.Activo = 1 AND ";
            
            try
            {
                if (campo == "Número")
                {
                    if (filtro.Length > 0)
                    {
                        switch (criterio)
                        {
                            case "Menor a":
                                consulta += "Numero < ";
                                break;
                            case "Mayor a":
                                consulta += "Numero > ";
                                break;
                            default:
                                consulta += "Numero = ";
                                break;
                        }

                        consulta += filtro + ";";
                    }
                    else
                        consulta += "1 = 1";
                }
                else
                {
                    if (campo == "Nombre")
                    {
                        consulta += "Nombre LIKE '";
                    }
                    else
                        consulta += "P.Descripcion LIKE '";

                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += filtro + "%';";
                            break;
                        case "Termina con":
                            consulta += "%" + filtro + "';";
                            break;
                        default:
                            consulta += "%" + filtro + "%';";
                            break;
                    }
                }
                datos.setConsulta(consulta);
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = datos.Lector.GetString(1);
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = datos.Lector.GetString(3);
                    aux.Tipo = new Elemento
                    {
                        Descripcion = datos.Lector.GetString(4)
                    };
                    aux.Tipo.id = (int)datos.Lector["IdTipo"];
                    aux.Debilidad = new Elemento
                    {
                        Descripcion = datos.Lector.GetString(5)
                    };
                    aux.Debilidad.id = (int)datos.Lector["IdDebilidad"];

                    lista.Add(aux);
                }

                return lista;
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
