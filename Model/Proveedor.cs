using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proveedor
    {
        public int id { get; set; }
        public string cuit { get; set; }
        public string razonSocial { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public bool activo { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaUltModificacion { get; set; }

    }
}
