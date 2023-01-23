using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace WindowsEducionIT.Models
{
    public class Plan
    {
        [Key]
        public int IDPlan { get; set; }
        public string Nombre { get; set; }

        public int IDCarrera { get; set; }
        [ForeignKey("IDCarrera")]
        public Carrera Carrera { get; set; }
    }
}
