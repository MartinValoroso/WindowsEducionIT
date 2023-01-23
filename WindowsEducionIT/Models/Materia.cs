using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WindowsEducionIT.Models
{
    public class Materia
    {
        [Key]
        public int IDMateria { get; set; }
        public string Nombre { get; set; }

        public List<Planilla> Planillas { get; set; }
    }
}
