﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplosADO_NET
{
    internal class Elemento
    {

        public int id {  get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return this.Descripcion;
        }

    }
}
