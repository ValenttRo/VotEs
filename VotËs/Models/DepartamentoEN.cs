using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VotES.Models
{
    public class DepartamentoEN
    {
        [Key]
        public int Departamento {  get; set; }
        public String? Nombre { get; set; }
    }
}
