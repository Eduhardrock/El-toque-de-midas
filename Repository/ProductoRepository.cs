using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelORM;

namespace Repository
{
    public class ProductoRepository
    {

        public producto crear(producto nuevoProducto)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevoProducto = db.productos.Add(nuevoProducto);
                db.SaveChanges();
                return nuevoProducto;
            }
        }

        public producto buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.productos.Find(id);
            }
        }

        public producto buscarPorSKU(string sku)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.productos
                    .Where(p => p.sku == sku)
                    .FirstOrDefault<producto>();
            }
        }

        public producto buscarPorCodigoBarra(string codigoBarra)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.productos
                    .Where(p => p.codigoBarra == codigoBarra)
                    .FirstOrDefault<producto>();
            }
        }

        public List<producto> buscarPorDescripcion(string descripcion)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.productos
                    .Where(p => p.descripcion.Contains(descripcion))
                    .ToList();
            }
        }

        public List<producto> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.productos.ToList();
            }
        }

        public producto eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var productoBd = db.productos.Find(id);
                db.productos.Remove(productoBd);
                db.SaveChanges();
                return productoBd;
            }
        }

        public producto actualizar(int id, producto productoActualizado)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var productoBD = db.productos.Find(id);
                productoBD.sku = productoActualizado.sku;
                productoBD.stock = productoActualizado.stock;
                productoBD.precio = productoActualizado.precio;
                productoBD.codigoBarra = productoActualizado.codigoBarra;
                productoBD.descripcion = productoActualizado.descripcion;
                productoBD.observaciones = productoActualizado.observaciones;
                productoBD.categoria = productoActualizado.categoria;
                productoBD.estado = productoActualizado.estado;
                productoBD.stock_minimo = productoActualizado.stock_minimo;

                db.SaveChanges();
                return productoBD;
            }
        }

    }
}
