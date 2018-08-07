using CoreApp.Infrastructure.Concrete;

namespace CoreApp.Tests.Common.Data
{
    public class DatabaseSeeder
    {
        private readonly ScoutContext context;

        public DatabaseSeeder(ScoutContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            context.Database.EnsureDeleted();

            context.Dens.AddRange(PredefinedData.Dens());
            context.Icons.AddRange(PredefinedData.Icons());
            context.Badges.AddRange(PredefinedData.Badges());
            context.Ranks.AddRange(PredefinedData.Ranks());
            context.Scouts.AddRange(PredefinedData.Scouts());
            context.Leaders.AddRange(PredefinedData.Leaders());
            context.ScoutBadges.AddRange(PredefinedData.ScoutBadges());
            context.SaveChanges();
        }
    }
}
