using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WindowsEducionIT.Models
{
    public class Estudiante
    {
        [Key]
        public int IDEstudiante { get; set; }

        public int IDLocalidad { get; set; }
        [ForeignKey("IDLocalidad")]
        public Localidad Localidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }
    }
}
