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

        public persona crear(persona nuevaPersona)
        {
            Console.WriteLine("Entre a crear persona");
            var cat = this.buscarPorDni(nuevaPersona.dni);

            Console.WriteLine("Resultado de buscar la persona en la bd : " + cat.id);
            if (cat != null)
            {
                throw new Exception("Ya existe un persona con el dni : " + nuevaPersona.dni);
            }
            return this.personaRepository.crear(nuevaPersona);
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


        public persona actualizar(int id, persona personaActualizada)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ningun persona con el id brindado. Verificar");
            }

            return this.personaRepository.actualizar(id, personaActualizada);
        }
    }
}
