using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VotES.Models
{
    public class TipoEleccionEN
    {
        [Key]
        public int IdTipo {  get; set; }
        public string Nombre { get; set; }
        public enum RangoAlcance
        {
            Nacional,
            Departamental,
            Municipal
        }
        public RangoAlcance Alcance { get; set; }
    }
}
