using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RolService
    {

        private RolRepository rolRepository = new RolRepository();

        public rol crear(rol nuevoRol)
        {
            Console.WriteLine("Entre a crear rol");
            var cat = this.buscar(nuevoRol.nombre);

            Console.WriteLine("Resultado de buscar la rol en la bd : " + cat.id);
            if (cat != null)
            {
                throw new Exception("Ya existe una rol con el nombre : " + nuevoRol.nombre);
            }
            return this.rolRepository.crear(nuevoRol);
        }


        public rol buscar(string nombrerol)
        {
            return this.rolRepository.buscar(nombrerol);
        }

        public rol buscarPorId(int id)
        {
            return this.rolRepository.buscarPorId(id);
        }


        public List<rol> listarTodas()
        {
            return this.rolRepository.listarTodas();
        }


        public rol eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("La rol que intenta eliminar no existe en la base de datos.");
            }

            return this.rolRepository.eliminar(id);
        }


        public rol actualizar(int id, string nombre)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ninguna rol con el id brindado. Verificar");
            }

            return this.rolRepository.actualizar(id, nombre);
        }
    }
}
