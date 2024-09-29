using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PermisoModel
    {
        public int id { get; set; }
        public RolModel oRol { get; set; }
        public string nombreMenu { get; set; }
    }
}
