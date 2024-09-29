using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Compra
    {
        public int id { get; set; }
        public UsuarioModel usuario { get; set; }
        public Proveedor proveedor { get; set; }
        public decimal montoTotal { get; set; }
        public string fechaCreacion { get; set; }
        public List<Compra> items { get; set; }
    }
}
