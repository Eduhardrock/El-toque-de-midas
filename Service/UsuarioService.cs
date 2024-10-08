using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using ModelORM;

namespace Service
{
    public class UsuarioService
    {

        private UsuarioRepository usuarioRepository = new UsuarioRepository();

        public List<usuario> listarTodos()
        {
            return this.usuarioRepository.listarTodos();
        }

        public usuario buscarPorUsername(string username)
        {
            return this.usuarioRepository.buscarPorUsername(username);
        }

        public List<usuario> buscarFiltrando(string dni, string username, int rol)
        {
            return this.usuarioRepository.buscarFiltrando(dni, username, rol);
        }

        public usuario agregar(usuario nuevoUsuario)
        {
            return this.usuarioRepository.agregar(nuevoUsuario);

        }

        public usuario actualizar(int idUsuario, usuario nuevoUsuario)
        {
            return this.usuarioRepository.actualizar(idUsuario, nuevoUsuario);

        }

        public usuario eliminarPorId(int idUsuario)
        {
            return this.usuarioRepository.eliminarPorId(idUsuario);
        }
    }
}
