using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VotES.Models
{
    public class VotanteEN
    {
        [Key]
        public int Id { get; set; }
        public string DocumentoHash { get; set; }
        public string Contraseña {  get; set; }
        public int IdMunicipio { get; set; }
        public bool Habilitado { get; set; }
        public int IntentoFallidos {  get; set; }
        public DateTime? Bloqueado {  get; set; }
    }
}
