using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TipoClienteRepository
    {

        public tipoCliente crear(tipoCliente nuevotipoCliente)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevotipoCliente = db.tipoClientes.Add(nuevotipoCliente);
                db.SaveChanges();
                return nuevotipoCliente;
            }
        }


        public tipoCliente buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.tipoClientes.Find(id);
            }
        }

        public tipoCliente buscar(string nombretipoCliente)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.tipoClientes
                              .Where(c => c.nombre == nombretipoCliente)
                              .FirstOrDefault<tipoCliente>();
            }
        }


        public List<tipoCliente> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.tipoClientes.ToList();
            }
        }


        public tipoCliente eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var tipoClienteBd = db.tipoClientes.Find(id);
                db.tipoClientes.Remove(tipoClienteBd);
                db.SaveChanges();
                return tipoClienteBd;
            }
        }


        public tipoCliente actualizar(int id, string nombre)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var tipoClienteBD = db.tipoClientes.Find(id);
                tipoClienteBD.nombre = nombre;
                db.SaveChanges();
                return tipoClienteBD;
            }
        }
    }
}
