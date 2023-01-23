using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WindowsEducionIT.Models
{
    public class Localidad
    {
        [Key]
        public int IDLocalidad { get; set; }
        public string Nombre { get; set; }

        public List<Profesor> profesores { get; set; }

        public List<Estudiante> estudiantes { get; set; }
    }
}
