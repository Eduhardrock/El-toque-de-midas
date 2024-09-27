using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RolRepository
    {

        public rol crear(rol nuevoRol)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevoRol = db.rols.Add(nuevoRol);
                db.SaveChanges();
                return nuevoRol;
            }
        }


        public rol buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.rols.Find(id);
            }
        }

        public rol buscar(string nombrerol)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.rols
                              .Where(c => c.nombre == nombrerol)
                              .FirstOrDefault<rol>();
            }
        }


        public List<rol> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.rols.ToList();
            }
        }


        public rol eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var rolBd = db.rols.Find(id);
                db.rols.Remove(rolBd);
                db.SaveChanges();
                return rolBd;
            }
        }


        public rol actualizar(int id, string nombre)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var rolBD = db.rols.Find(id);
                rolBD.nombre = nombre;
                db.SaveChanges();
                return rolBD;
            }
        }
    }
}
