using System;
using System.Collections.Generic;
using System.Text;

namespace VotES.Models
{
    public class VotanteEN
    {
        public int IdVotante { get; set; }
        public string DocumentoHash { get; set; }
        public string Contraseña {  get; set; }
        public ushort IdMunicipio { get; set; }
        public bool Habilitado { get; set; }
        public int IntentosFallidos {  get; set; }
        public DateTime? Bloqueado {  get; set; }
    }
}
