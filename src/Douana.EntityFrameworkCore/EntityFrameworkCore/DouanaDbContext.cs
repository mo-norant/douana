using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Douana.Authorization.Roles;
using Douana.Authorization.Users;
using Douana.Models;
using Douana.Models.Enumerations;
using Douana.Models.Models.Travel;
using Douana.Models.Travel;
using Douana.MultiTenancy;

namespace Douana.EntityFrameworkCore
{
    public class DouanaDbContext : AbpZeroDbContext<Tenant, Role, User, DouanaDbContext>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CustomsForm> CustomsForms { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<CustomsRequest> CustomsRequests { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<BoatTrip> BoatTrips { get; set; }
        public DbSet<PassportNumber> PassportNumbers { get; set; }
        public DouanaDbContext(DbContextOptions<DouanaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetupVisitingMotivesEnum(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }


        private void SetupVisitingMotivesEnum(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CustomsForm>()
                .Property(e => e.VisitingMotives)
                .HasConversion(
                    v => v.ToString(),
                    v => (ICollection<VisitingMotives>)Enum.Parse(typeof(VisitingMotives), v));
        }
    }
}
