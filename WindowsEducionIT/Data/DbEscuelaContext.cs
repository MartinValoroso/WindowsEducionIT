using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using WindowsEducionIT.Models;


namespace WindowsEducionIT.Data
{
    public class DbEscuelaContext : DbContext
    {
        public DbEscuelaContext() : base("KeyDB") { }

        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Planilla> Planillas { get; set; }
    }
}
