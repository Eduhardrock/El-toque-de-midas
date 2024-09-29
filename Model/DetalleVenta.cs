using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DetalleVenta
    {
        public int idVenta { get; set; }
        public Producto idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }

    }
}
