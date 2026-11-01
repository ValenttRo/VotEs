using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VotES.Models
{
    public class MunicipiosEN
    {
        [Key]
        public int Municipio {  get; set; }
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

    }
}
