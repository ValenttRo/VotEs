using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VotES.Models
{
    public class PartidosEN
    {
        [Key]
        public int IdPartido {  get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }

    }
}
