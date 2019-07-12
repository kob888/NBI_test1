using System;
using System.Data.Entity;
using Test_1_NBI.Models;

namespace Test_1_NBI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name = MyDB") { }

        public DbSet<City> Cities { get; set; }
        public DbSet<Fact> Facts { get; set; }

    }
}
