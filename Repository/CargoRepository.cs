using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CargoRepository
    {
        public cargo crear(cargo nuevoCargo)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevoCargo = db.cargos.Add(nuevoCargo);
                db.SaveChanges();
                return nuevoCargo;
            }
        }


        public cargo buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.cargos.Find(id);
            }
        }

        public cargo buscar(string nombreCargo)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.cargos
                              .Where(c => c.nombre == nombreCargo)
                              .FirstOrDefault<cargo>();
            }
        }


        public List<cargo> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.cargos.ToList();
            }
        }


        public cargo eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var cargoBd = db.cargos.Find(id);
                db.cargos.Remove(cargoBd);
                db.SaveChanges();
                return cargoBd;
            }
        }


        public cargo actualizar(int id, string nombre)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var cargoBD = db.cargos.Find(id);
                cargoBD.nombre = nombre;
                db.SaveChanges();
                return cargoBD;
            }
        }
    }
}
