using Microsoft.EntityFrameworkCore;
using VotËs.Models;
using VotES.Models;


namespace VotËs.Data
{
    public class VotoDigitalContext : DbContext
    {
        public VotoDigitalContext(DbContextOptions<VotoDigitalContext> options)
           : base(options) { }
        
        public DbSet<CandidatosEN> candidatos { get; set; }
        public DbSet<DepartamentoEN> departamentos { get; set; }
        
        public DbSet<EleccionesEN> elecciones { get; set; }
        public DbSet<MunicipiosEN> municipios { get; set; }
        public DbSet<ParticipacionEN> participacion_votante {  get; set; }
        public DbSet<PartidosEN> partidos { get; set; }
        public DbSet<TipoEleccionEN> tipo_eleccion { get; set; }
        public DbSet<VotanteEN> votante {  get; set; }
        public DbSet<VotoEN> voto { get; set; }

    }
}
