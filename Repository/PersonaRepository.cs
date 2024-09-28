﻿using ModelORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PersonaRepository
    {

        public persona crear(persona nuevaPersona)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                nuevaPersona = db.personas.Add(nuevaPersona);
                db.SaveChanges();
                return nuevaPersona;
            }
        }


        public persona buscarPorId(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.personas.Find(id);
            }
        }

        public persona buscarPorDni(string dni)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.personas
                              .Where(p => p.dni == dni)
                              .FirstOrDefault<persona>();
            }
        }


        public List<persona> listarTodas()
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                return db.personas.ToList();
            }
        }


        public persona eliminar(int id)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var personaBd = db.personas.Find(id);
                db.personas.Remove(personaBd);
                db.SaveChanges();
                return personaBd;
            }
        }


        public persona actualizar(int id, persona personaActualizada)
        {
            using (midasTouchEntities db = new midasTouchEntities())
            {
                var personaBD = db.personas.Find(id);
                personaBD.nombre = personaActualizada.nombre;
                personaBD.apellido = personaActualizada.apellido;
                personaBD.email = personaActualizada.email;
                personaBD.fechaNacimiento = personaActualizada.fechaNacimiento;
                personaBD.telefono = personaActualizada.telefono;
                db.SaveChanges();
                return personaBD;
            }
        }
    }
}
