using DataBase;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos con = new AccesoDatos();

            try
            {
                con.setConsulta("SELECT Id, Descripcion FROM MARCAS;");
                con.ejecutarQuery();

                while (con.Reader.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)con.Reader["Id"];
                    marca.Descripcion = (string)con.Reader["Descripcion"];
                    lista.Add(marca);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.cerrarConexion();
            }
        }
    }
}
