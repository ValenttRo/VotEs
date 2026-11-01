using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VotES.Models
{
    public class CandidatosEN
    {
        [Key]
        public int IdCandidato { get; set; }
        public int IdEleccion  { get; set; }
        public int IdPartido {  get; set; }
        public string Nombre {  get; set; }
        public bool EnBlanco {  get; set; }
    }
}
