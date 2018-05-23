using CoreApp.Core.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.Infrastructure.Concrete
{
    public class ScoutContext : DbContext
    {
        public ScoutContext(DbContextOptions<ScoutContext> options) : base(options)
        { }

        public DbSet<Scout> Scouts { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Den> Dens { get; set; }
        public DbSet<Leader> Leaders { get; set; }
    }
}
