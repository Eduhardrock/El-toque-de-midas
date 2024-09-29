using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoriaRepository
    {

        public categoria crear(categoria nuevaCategoria)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevaCategoria = db.categorias.Add(nuevaCategoria);
                db.SaveChanges();
                return nuevaCategoria;
            }
        }


        public categoria buscarPorId(int id)
        {
            using(midasTouchEntities db = new midasTouchEntities())
            {
                return db.categorias.Find(id);
            }
        }

        public categoria buscar(string nombreCategoria)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.categorias
                              .Where(c => c.nombre == nombreCategoria)
                              .FirstOrDefault<categoria>();
            }
        }


        public List<categoria> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.categorias.ToList();
            }
        }


        public categoria eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var categoriaBd = db.categorias.Find(id);
                db.categorias.Remove(categoriaBd);
                db.SaveChanges();
                return categoriaBd;
            }
        }


        public categoria actualizar(int id, string nombre)
        {
            using(midasTouchEntities db = new midasTouchEntities())
            {
                var categoriaBD = db.categorias.Find(id);
                categoriaBD.nombre = nombre;
                db.SaveChanges();
                return categoriaBD;
            }
        }


    }
}
