using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Unitas.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
        /// <summary>
        /// used for accessing all available addresses.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Council> Councils { get; set; }
        //public DbSet<ApplicationUser> members { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Address>().HasData(
                new Address(-1,"Houston ", "TX"),
                new Address(-2,"Green Bay", "WI"),
                new Address(-3,"Hortonville", "WI"),
                new Address(-4,"Greenville", "WI"),
                new Address(-5,"Appleton", "WI")
                );
            
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
