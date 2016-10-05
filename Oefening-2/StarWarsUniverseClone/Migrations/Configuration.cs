namespace StarWarsUniverseClone.Migrations
{
    using Services;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StarWarsUniverseClone.DataLayer.StarWarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StarWarsUniverseClone.DataLayer.StarWarsContext context)
        {
            SWDataService swDataService = new SWDataService();
            var list = swDataService.GetAllSWMovies();
            var planetList = swDataService.GetAllSWPlanet();

            foreach (var item in list)
            {
                context.SWMovie.AddOrUpdate(item);
            }

            foreach (var item in planetList)
            {
                context.SWPlanet.AddOrUpdate(item);
            }

            context.SaveChanges();
        }
    }
}
