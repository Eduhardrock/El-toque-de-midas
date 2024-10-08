using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmpleadoRepository
    {


        public empleado crear(empleado nuevoempleado)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevoempleado = db.empleados.Add(nuevoempleado);
                db.SaveChanges();
                return nuevoempleado;
            }
        }


        public empleado buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.empleados.Find(id);
            }
        }

        public empleado buscarPorCuit(string cuit)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.empleados
                              .Where(c => c.cuit == cuit)
                              .FirstOrDefault<empleado>();
            }
        }


        public List<empleado> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.empleados.ToList();
            }
        }


        public empleado eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var empleadoBd = db.empleados.Find(id);
                db.empleados.Remove(empleadoBd);
                db.SaveChanges();
                return empleadoBd;
            }
        }


        public empleado actualizar(int id, empleado empleadoActualizado)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var empleadoBD = db.empleados.Find(id);
                empleadoBD.cuit = empleadoActualizado.cuit;
                empleadoBD.id_cargo = empleadoActualizado.id_cargo;
                empleadoBD.id_persona = empleadoActualizado.id_persona;
                empleadoBD.fechaEgreso = empleadoActualizado.fechaEgreso;
                empleadoBD.fechaUltModificacion = new DateTime();
                db.SaveChanges();
                return empleadoBD;
            }
        }

        public empleado buscarPorIdPersona(int idPersona)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.empleados
                              .Where(c => c.id_persona == idPersona)
                              .FirstOrDefault<empleado>();
            }
        }
    }
}
