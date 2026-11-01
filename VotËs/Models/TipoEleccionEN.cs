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
        public enum Alcance
        {
            Nacional,
            Departamental,
            Municipal
        }
        public Alcance AlcanceEleccion { get; set; }
    }
}
