﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni {  get; set; }
        public bool activo { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaUltModificacion { get; set; }
    }
}
