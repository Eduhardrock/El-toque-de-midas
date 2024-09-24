using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Producto
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string codigoBarra { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }
        public Proveedor proveedor { get; set; }
        public Categoria categoria { get; set; }
        public bool activo { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaUltModificacion { get; set; }
    }
}
