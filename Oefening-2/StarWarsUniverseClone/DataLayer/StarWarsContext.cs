﻿using StarWarsUniverse.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUniverseClone.DataLayer
{
    class StarWarsContext : DbContext
    {
        public StarWarsContext() : base("StarWarsDB")
        {

        }

        public DbSet<SWMovie> SWMovie { get; set; }
        public DbSet<SWPlanet> SWPlanet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SWMovie>().HasKey(s => s.ResourceUri);
            modelBuilder.Entity<SWPlanet>().HasKey(s => s.ResourceUri);
        }
        
    }
}
