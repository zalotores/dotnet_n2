using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using Dominio;



namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos con = new AccesoDatos();

            try
            {
                con.setConsulta("SELECT Id, Descripcion FROM CATEGORIAS;");
                con.ejecutarQuery();

                while(con.Reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)con.Reader["Id"];
                    categoria.Descripcion = (string)con.Reader["Descripcion"];
                    lista.Add(categoria);
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
