using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WindowsEducionIT.Models
{
    public class Detalle
    {
        [Key]
        public int IdDetalle { get; set; }

        public int IDEstado { get; set; }

        #region propiedades de navegación
        [ForeignKey("IDEstado")]
        public Estado Estado { get; set; }
        #endregion
        public List<Evaluacion> Evalaciones { get; set; }

    
    }
}
