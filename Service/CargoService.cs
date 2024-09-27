using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CargoService
    {

        private CargoRepository cargoRepository = new CargoRepository();

        public cargo crear(cargo nuevoCargo)
        {
            Console.WriteLine("Entre a crear cargo");
            var cat = this.buscar(nuevoCargo.nombre);

            Console.WriteLine("Resultado de buscar la cargo en la bd : " + cat.id);
            if (cat != null)
            {
                throw new Exception("Ya existe una cargo con el nombre : " + nuevoCargo.nombre);
            }
            return this.cargoRepository.crear(nuevoCargo);
        }


        public cargo buscar(string nombreCargo)
        {
            return this.cargoRepository.buscar(nombreCargo);
        }

        public cargo buscarPorId(int id)
        {
            return this.cargoRepository.buscarPorId(id);
        }


        public List<cargo> listarTodas()
        {
            return this.cargoRepository.listarTodas();
        }


        public cargo eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("La cargo que intenta eliminar no existe en la base de datos.");
            }

            return this.cargoRepository.eliminar(id);
        }


        public cargo actualizar(int id, string nombre)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ninguna cargo con el id brindado. Verificar");
            }

            return this.cargoRepository.actualizar(id, nombre);
        }
    }
}
