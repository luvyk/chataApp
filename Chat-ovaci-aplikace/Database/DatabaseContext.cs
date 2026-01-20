using Chat_ovaci_aplikace.Entities;
using Microsoft.EntityFrameworkCore;

namespace Chat_ovaci_aplikace.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Akce> Akces { get; set; }
        public DbSet<Den> Dny { get; set; }
        public DbSet<Chata> Chaty { get; set; }
        public DbSet<Mistnost> Mistnosti { get; set; }
        public DbSet<Misto> Mista { get; set; }
        public DbSet<PrihlasenyUZ> PrihlaseniUZ { get; set; }
        public DbSet<ProgramChaty> Programy { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUcastnik> RoleUcastniks { get; set; }
        public DbSet<Typ> Types { get; set; }
        public DbSet<Ucastnik> Ucastnici { get; set; }
        public DbSet<UcastnikAkce> UcastnikAkces { get; set; }
        public DbSet<Ukoly> Ukoly { get; set; }
        public DbSet<Uzivatel> Uzivatele { get; set; }
        public DbSet<Vlakno> Vlakna { get; set; }
        public DbSet<Zprava> Zpravy { get; set; }
        public DatabaseContext(DbContextOptions options)
            : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
