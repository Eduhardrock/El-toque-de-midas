using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EstadoService
    {

        private EstadoRepository estadoRepository = new EstadoRepository();

        public estado crear(estado nuevoEstado)
        {
            Console.WriteLine("Entre a crear estado");
            var cat = this.buscar(nuevoEstado.nombre);

            Console.WriteLine("Resultado de buscar la estado en la bd : " + cat.id);
            if (cat != null)
            {
                throw new Exception("Ya existe un estado con el nombre : " + nuevoEstado.nombre);
            }
            return this.estadoRepository.crear(nuevoEstado);
        }


        public estado buscar(string nombreEstado)
        {
            return this.estadoRepository.buscar(nombreEstado);
        }

        public estado buscarPorId(int id)
        {
            return this.estadoRepository.buscarPorId(id);
        }


        public List<estado> listarTodas()
        {
            return this.estadoRepository.listarTodas();
        }


        public estado eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("La estado que intenta eliminar no existe en la base de datos. ");
            }

            return this.estadoRepository.eliminar(id);
        }


        public estado actualizar(int id, string nombre)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ningun estado con el id brindado. Verificar");
            }

            return this.estadoRepository.actualizar(id, nombre);
        }
    }
}
