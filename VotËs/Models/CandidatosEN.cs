using System;
using System.Collections.Generic;
using System.Text;

namespace VotES.Models
{
    public class CandidatosEN
    {
        public int IdCandidato { get; set; }
        public int IdEleccion  { get; set; }
        public int IdPartido {  get; set; }
        public string Nombre {  get; set; }
        public bool EnBlanco {  get; set; }
    }
}
