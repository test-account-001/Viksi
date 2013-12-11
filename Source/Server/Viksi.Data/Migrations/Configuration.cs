namespace TelerikHackaton.Ruler.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using Viksi.Data;

    public sealed class Configuration : DbMigrationsConfiguration<ViksiDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ViksiDbContext context)
        {
        }
    }
}