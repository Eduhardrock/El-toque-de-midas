using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClienteRepository
    {
        public cliente crear(cliente nuevoCliente)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevoCliente = db.clientes.Add(nuevoCliente);
                db.SaveChanges();
                return nuevoCliente;
            }
        }


        public cliente buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.clientes.Find(id);
            }
        }

        public cliente buscarPorDni(string dni)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.clientes
                              .Where(c => c.persona.dni == dni)
                              .FirstOrDefault<cliente>();
            }
        }


        public List<cliente> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.clientes.ToList();
            }
        }


        public cliente eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var clienteBd = db.clientes.Find(id);
                db.clientes.Remove(clienteBd);
                db.SaveChanges();
                return clienteBd;
            }
        }


        public cliente actualizar(int id, string nombre)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var clienteBD = db.clientes.Find(id);
                clienteBD.nombre = nombre;
                db.SaveChanges();
                return clienteBD;
            }
        }
    }
}
