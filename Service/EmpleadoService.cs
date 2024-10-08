using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EmpleadoService
    {

        private EmpleadoRepository empleadoRepository = new EmpleadoRepository();

        public empleado crear(empleado nuevoEmpleado)
        {
            Console.WriteLine("Entre a crear empleado");
            var cat = this.buscarPorCuit(nuevoEmpleado.cuit);

            Console.WriteLine("Resultado de buscar la empleado en la bd : " + cat.id);
            if (cat != null)
            {
                throw new Exception("Ya existe un empleado con el nombre : " + nuevoEmpleado.cuit);
            }
            return this.empleadoRepository.crear(nuevoEmpleado);
        }


        public empleado buscarPorCuit(string cuit)
        {
            return this.empleadoRepository.buscarPorCuit(cuit);
        }

        public empleado buscarPorIdPersona(int idPersona)
        {
            return this.empleadoRepository.buscarPorIdPersona(idPersona);
        }

        public empleado buscarPorId(int id)
        {
            return this.empleadoRepository.buscarPorId(id);
        }


        public List<empleado> listarTodas()
        {
            return this.empleadoRepository.listarTodas();
        }


        public empleado eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("La empleado que intenta eliminar no existe en la base de datos.");
            }

            return this.empleadoRepository.eliminar(id);
        }


        public empleado actualizar(int id, empleado empleadoActualizado)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ningun empleado con el id brindado. Verificar");
            }

            return this.empleadoRepository.actualizar(id, empleadoActualizado);
        }
    }
}
