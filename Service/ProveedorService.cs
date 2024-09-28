using ModelORM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProveedorService
    {

        private ProveedorRepository proveedorRepository = new ProveedorRepository();

        public proveedor crear(proveedor nuevoProveedor)
        {
            Console.WriteLine("Entre a crear proveedor");
            var proveedorBD = this.buscarPorCuit(nuevoProveedor.cuit);

            Console.WriteLine("Resultado de buscar la proveedor en la bd : " + proveedorBD.razonSocial);
            if (proveedorBD != null)
            {
                throw new Exception("Ya existe una proveedor con el nombre : " + proveedorBD.ToString());
            }
            return this.proveedorRepository.crear(proveedorBD);
        }


        public proveedor buscarPorCuit(string cuit)
        {
            return this.proveedorRepository.buscarPorCuit(cuit);
        }

        public proveedor buscarPorId(int id)
        {
            return this.proveedorRepository.buscarPorId(id);
        }

        public List<proveedor> listarTodas()
        {
            return this.proveedorRepository.listarTodas();
        }

        public proveedor eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("El proveedor que intenta eliminar no existe en la base de datos.");
            }

            return this.proveedorRepository.eliminar(id);
        }

        public proveedor actualizar(int id, proveedor proveedorActualizado)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ninguna proveedor con el id brindado. Verificar");
            }

            return this.proveedorRepository.actualizar(id, proveedorActualizado);
        }
    }
}
