using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool activo { get; set; }
        public RolModel rol { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaUltModificacion { get; set; }
    }
}
