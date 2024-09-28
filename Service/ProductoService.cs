using Repository;
using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.validaciones;

namespace Service
{
    public class ProductoService
    {

        private ProductoRepository productoRepository = new ProductoRepository();
        private CategoriaService categoriaService = new CategoriaService();
        private ProveedorService proveedorService = new ProveedorService();

        private ProductoValidaciones ProductoValidaciones = new ProductoValidaciones();

        public producto crear(producto nuevoProducto)
        {
            Console.WriteLine("Entre a crear producto");

            this.ProductoValidaciones.validate(nuevoProducto);
            Console.WriteLine("Pase las validaciones");

            var productoBD = this.buscarPorSku(nuevoProducto.sku);

            Console.WriteLine("Resultado de buscar la producto en la bd : " + productoBD.ToString());
            if (productoBD != null)
            {
                throw new Exception("Ya existe una producto con el nombre : " + productoBD.ToString());
            }

            return this.productoRepository.crear(productoBD);
        }



        public producto buscarPorId(int id)
        {
            return this.productoRepository.buscarPorId(id);
        }

        public producto buscarPorSku(string sku)
        {
            return this.productoRepository.buscarPorSKU(sku);
        }

        public List<producto> listarTodas()
        {
            return this.productoRepository.listarTodas();
        }

        public producto eliminar(int id)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("El producto que intenta eliminar no existe en la base de datos.");
            }

            return this.productoRepository.eliminar(id);
        }

        public producto actualizar(int id, producto productoActualizado)
        {
            var cat = this.buscarPorId(id);
            if (cat == null)
            {
                throw new Exception("No existe ninguna producto con el id brindado. Verificar");
            }

            return this.productoRepository.actualizar(id, productoActualizado);
        }
    }
}
