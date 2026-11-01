using System.ComponentModel.DataAnnotations;

namespace VotËs.Models
{
    public class ParticipacionEN
    {
        [Key]
        public int VotoId { get; set; }
        public int EleccionId { get; set; }
        public DateTime FechaDeVoto { get; set; }
    }
}
