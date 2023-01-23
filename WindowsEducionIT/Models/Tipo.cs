using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WindowsEducionIT.Models
{
    public class Tipo
    {
        [Key]
        public int IDTipo { get; set; }
        public string Nombre { get; set; }
        public List<Evaluacion> Evalaciones { get; set; }


    }
}
