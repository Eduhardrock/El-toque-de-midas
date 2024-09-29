using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ClienteService
    {

        private ClienteRepository clienteRepository = new ClienteRepository();

        private PersonaService personaService = new PersonaService();

        public cliente crear(cliente nuevoCliente)
        {
            Console.WriteLine("Entre a crear cliente");
            persona p = null;
            if (nuevoCliente.id_persona != null)
            {
                p = this.personaService.buscarPorId(nuevoCliente.id_persona);
                nuevoCliente.persona = p;
            }

            return this.clienteRepository.crear(nuevoCliente);
        }


        public cliente buscarPorDni(string dni)
        {
            return this.clienteRepository.buscarPorDni(dni);
        }

        public cliente buscarPorId(int id)
        {
            return this.clienteRepository.buscarPorId(id);
        }


        public List<cliente> listarTodas()
        {
            return this.clienteRepository.listarTodas();
        }


        public cliente eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("La cliente que intenta eliminar no existe en la base de datos.");
            }

            return this.clienteRepository.eliminar(id);
        }


        public cliente actualizar(int id, cliente clienteActualizado)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ningun cliente con el id brindado. Verificar");
            }

            return this.clienteRepository.actualizar(id, clienteActualizado);
        }
    }
}
