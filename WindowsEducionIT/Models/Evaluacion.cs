using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WindowsEducionIT.Models
{
    public class Evaluacion
    {
        [Key]
        public int IDEvaluacion { get; set; }

        public int IDTipo { get; set; }
        [ForeignKey("IDTipo")]
        public Tipo Tipo { get; set; }
        public int IDEstudiante { get; set; }
        [ForeignKey("IDEstudiante")]
        public Estudiante Estudiante { get; set; }
        public int IDDetalle { get; set; }
        [ForeignKey("IDDetalle")]
        public Detalle Detalle { get; set; }
        public string Nota { get; set; }

    }
}
