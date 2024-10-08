using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ModelORM;
using System.Data.Entity;

namespace Repository
{
    public class UsuarioRepository
    {

        public List<usuario> listarTodos() {
            List<usuario> userList = new List<usuario>();

            using (midasTouchEntities db = new midasTouchEntities()) {
                userList = db.usuarios
                              .Include(u => u.rol)
                              .Include(u => u.empleado)
                              .Include(u => u.empleado.persona)
                              .ToList<usuario>();
            }

            return userList;
        }

        public usuario buscarPorUsername(string username)
        {
            Console.WriteLine("Buscando usuario con username : " + username);
            usuario usuarioBd = new usuario();

            using (midasTouchEntities db = new midasTouchEntities())
            {
                usuarioBd = db.usuarios
                              .Where(u => u.username == username)
                              .FirstOrDefault<usuario>();
            }

            return usuarioBd;
        }

        public List<usuario> buscarFiltrando(string dni, string username, int rol)
        {
            /*List<usuario> userList = new List<usuario>();

            using (midasTouchEntities db = new midasTouchEntities())
            {
                userList = db.usuarios
                                .Where(u => u.username == username && u.id_rol == rol)
                                .Where(u => u.rol == username)
                              .Include(u => u.rol)
                              .Include(u => u.empleado)
                              .Include(u => u.empleado.persona)
                              .ToList<usuario>();
            }*/

            return null;
        }

        public usuario agregar(usuario nuevoUsuario)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevoUsuario = db.usuarios.Add(nuevoUsuario);
                db.SaveChanges();
            }

            return nuevoUsuario;

        }

        public usuario actualizar(int idUsuario, usuario nuevoUsuario)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var userBd = db.usuarios.Find(idUsuario);
                if (userBd != null)
                {
                    userBd.pass = nuevoUsuario.pass;
                    userBd.username = nuevoUsuario.username;
                    userBd.id_rol = nuevoUsuario.id_rol;
                    db.SaveChanges();
                }

                return userBd;
            }

        }

        public usuario eliminarPorId(int idUsuario)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var userBd = db.usuarios.Find(idUsuario);
                if (userBd != null)
                {
                    db.usuarios.Remove(userBd);
                    db.SaveChanges();
                }
                return userBd;
            }
        }

    }
}
