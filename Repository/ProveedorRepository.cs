using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelORM;


namespace Repository
{
    public class ProveedorRepository
    {
        public proveedor crear(proveedor nuevoProveedor)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevoProveedor = db.proveedors.Add(nuevoProveedor);
                db.SaveChanges();
                return nuevoProveedor;
            }
        }

        public proveedor buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.proveedors.Find(id);
            }
        }

        public proveedor buscarPorCuit(string cuit)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.proveedors
                              .Where(p => p.cuit == cuit)
                              .FirstOrDefault<proveedor>();
            }
        }

        public List<proveedor> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.proveedors.ToList();
            }
        }

        public proveedor eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var proveedorBd = db.proveedors.Find(id);
                db.proveedors.Remove(proveedorBd);
                db.SaveChanges();
                return proveedorBd;
            }
        }

        public proveedor actualizar(int id, proveedor proveedorActualizado)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var proveedorBD = db.proveedors.Find(id);
                
                proveedorBD.razonSocial = proveedorActualizado.razonSocial;
                proveedorBD.cuit = proveedorActualizado.cuit;
                proveedorBD.observaciones = proveedorActualizado.observaciones;
                proveedorBD.telefono = proveedorActualizado.telefono;
                proveedorBD.email = proveedorActualizado.email;
                proveedorBD.domicilio = proveedorActualizado.domicilio;

                db.SaveChanges();
                return proveedorBD;
            }
        }
    }
}
