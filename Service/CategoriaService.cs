using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CategoriaService
    {

        private CategoriaRepository categoriaRepository = new CategoriaRepository();

        public categoria crear(categoria nuevaCategoria)
        {
            Console.WriteLine("Entre a crear categoria");
            var cat = this.buscar(nuevaCategoria.nombre);

            Console.WriteLine("Resultado de buscar la categoria en la bd : " + cat.id);
            if (cat != null)
            {
                throw new Exception("Ya existe una categoria con el nombre : " + nuevaCategoria.nombre);
            }
            return this.categoriaRepository.crear(nuevaCategoria);
        }


        public categoria buscar(string nombreCategoria)
        {
            return this.categoriaRepository.buscar(nombreCategoria);
        }

        public categoria buscarPorId(int id)
        {
            return this.categoriaRepository.buscarPorId(id);
        }


        public List<categoria> listarTodas()
        {
            return this.categoriaRepository.listarTodas();
        }


        public categoria eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if(cat == null)
            {
                throw new Exception("La categoria que intenta eliminar no existe en la base de datos.");
            }

            return this.categoriaRepository.eliminar(id);
        }


        public categoria actualizar(int id, string nombre)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ninguna categoria con el id brindado. Verificar");
            }

            return this.categoriaRepository.actualizar(id, nombre);
        }
    }
}
