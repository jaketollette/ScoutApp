namespace CoreApp.Core.Concrete
{
    public class ScoutBadge
    {
        public int ScoutId { get; set; }
        public Scout Scout { get; set; }

        public int BadgeId { get; set; }
        public Badge Badge { get; set; }
    }
}
