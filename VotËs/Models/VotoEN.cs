using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VotES.Models
{
    public class VotoEN
    {
        [Key]
        public Guid VotoId { get; set; }
        public int IdEleccion { get; set; }
        public int IdCandidato { get; set; }


    }
}
