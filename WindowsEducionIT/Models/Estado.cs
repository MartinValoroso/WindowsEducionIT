using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Text;

namespace WindowsEducionIT.Models
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }

        public string Nombre { get; set; }

        public List<Detalle> Detalles { get; set; }
    }
}
