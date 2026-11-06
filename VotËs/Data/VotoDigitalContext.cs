using Microsoft.EntityFrameworkCore;
using VotËs.Models;
using VotES.Models;


namespace VotËs.Data
{
    public class VotoDigitalContext : DbContext
    {
        public VotoDigitalContext()
        {
            
        }
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
        public DbSet<VotoEN> votos { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<ParticipacionEN>(e => 
            {
                e.HasKey(i => new{i.IdVotante, i.IdEleccion });

            });
            mb.Entity<TipoEleccionEN>(e =>
            {
                e.Property(i => i.Alcance).HasConversion<string>();
            });
            mb.Entity<EleccionesEN>(e =>
            {
                e.Property(i => i.EstadoDeEleccion).HasConversion<string>();
                
            });
            mb.Entity<EleccionesEN>().HasOne(e => e.TipoEleccion).WithMany().HasForeignKey(e => e.IdTipo);
            mb.Entity<ParticipacionEN>()
                .Property(e => e.FechaDeVoto).HasConversion(v => v.ToDateTime(TimeOnly.MinValue),v => DateOnly.FromDateTime(v));
        }

    }
    
}
