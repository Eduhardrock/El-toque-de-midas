using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TipoClienteService
    {

        private TipoClienteRepository tipoClienteRepository = new TipoClienteRepository();

        public tipoCliente crear(tipoCliente nuevotipoCliente)
        {
            Console.WriteLine("Entre a crear tipoCliente");
            var cat = this.buscar(nuevotipoCliente.nombre);

            Console.WriteLine("Resultado de buscar la tipoCliente en la bd : " + cat.id);
            if (cat != null)
            {
                throw new Exception("Ya existe un tipoCliente con el nombre : " + nuevotipoCliente.nombre);
            }
            return this.tipoClienteRepository.crear(nuevotipoCliente);
        }


        public tipoCliente buscar(string nombrtipoCliente)
        {
            return this.tipoClienteRepository.buscar(nombrtipoCliente);
        }

        public tipoCliente buscarPorId(int id)
        {
            return this.tipoClienteRepository.buscarPorId(id);
        }


        public List<tipoCliente> listarTodas()
        {
            return this.tipoClienteRepository.listarTodas();
        }


        public tipoCliente eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("La tipoCliente que intenta eliminar no existe en la base de datos.");
            }

            return this.tipoClienteRepository.eliminar(id);
        }


        public tipoCliente actualizar(int id, string nombre)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ningun tipoCliente con el id brindado. Verificar");
            }

            return this.tipoClienteRepository.actualizar(id, nombre);
        }
    }
}
