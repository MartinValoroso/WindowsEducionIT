using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WindowsEducionIT.Models
{
    public class Carrera
    {
        [Key]
        public int IDCarrera { get; set; }
        public string Nombre { get; set; }

        public List<Planilla> Planillas { get; set; }
    }
}
