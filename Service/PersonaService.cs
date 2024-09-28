using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PersonaService
    {

        private PersonaRepository personaRepository = new PersonaRepository();

        public persona crear(persona nuevapersona)
        {
            Console.WriteLine("Entre a crear persona");
            var cat = this.buscarPorDni(nuevapersona.nombre);

            Console.WriteLine("Resultado de buscar la persona en la bd : " + cat.id);
            if (cat != null)
            {
                throw new Exception("Ya existe una persona con el nombre : " + nuevapersona.nombre);
            }
            return this.personaRepository.crear(nuevapersona);
        }

        public persona buscarPorDni(string dni)
        {
            return this.personaRepository.buscarPorDni(dni);
        }

        public persona buscarPorId(int id)
        {
            return this.personaRepository.buscarPorId(id);
        }

        public List<persona> listarTodas()
        {
            return this.personaRepository.listarTodas();
        }

        public persona eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("La persona que intenta eliminar no existe en la base de datos.");
            }

            return this.personaRepository.eliminar(id);
        }

        public persona actualizar(int id, string nombre)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ninguna persona con el id brindado. Verificar");
            }

            return this.personaRepository.actualizar(id, nombre);
        }
    }
}
