using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DetalleCompra
    {
        public int idDetalleCompra {  get; set; }
        public Producto producto { get; set; }
        public decimal precioCompra { get; set; }
        public int cantidad { get; set; }
    }
}
