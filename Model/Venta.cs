using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venta
    {
        public int id { get; set; }
        public string fechaCreacion { get; set; }
        public Cliente cliente { get; set; }
        public UsuarioModel usuario { get; set; }
        public decimal montoTotal { get; set; }
        public List<DetalleVenta> detalle { get; set; }
    }
}
