using System.ComponentModel.DataAnnotations;

namespace VotËs.Models
{
    public class ParticipacionEN
    {
        
        public int IdVotante { get; set; }
        public int IdEleccion { get; set; }
        public DateOnly FechaDeVoto { get; set; }
    }
}
