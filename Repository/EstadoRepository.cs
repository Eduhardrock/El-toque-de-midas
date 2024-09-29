using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EstadoRepository
    {

        public estado crear(estado nuevoEstado)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevoEstado = db.estados.Add(nuevoEstado);
                db.SaveChanges();
                return nuevoEstado;
            }
        }


        public estado buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.estados.Find(id);
            }
        }

        public estado buscar(string nombreEstado)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.estados
                              .Where(c => c.nombre == nombreEstado)
                              .FirstOrDefault<estado>();
            }
        }


        public List<estado> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.estados.ToList();
            }
        }


        public estado eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var estadoBd = db.estados.Find(id);
                db.estados.Remove(estadoBd);
                db.SaveChanges();
                return estadoBd;
            }
        }


        public estado actualizar(int id, string nombre)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var estadoBD = db.estados.Find(id);
                estadoBD.nombre = nombre;
                db.SaveChanges();
                return estadoBD;
            }
        }
    }
}
