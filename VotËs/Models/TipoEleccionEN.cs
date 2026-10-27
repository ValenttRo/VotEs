using System;
using System.Collections.Generic;
using System.Text;

namespace VotES.Models
{
    public class TipoEleccionEN
    {
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
