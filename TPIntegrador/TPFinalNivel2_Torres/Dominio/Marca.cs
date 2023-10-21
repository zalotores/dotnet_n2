using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public Marca() { }
        //constructor para generar marca con id y descripcion
        public Marca(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
        public int Id {  get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
