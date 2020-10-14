using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HMS.Models
{
    public class HMSContext : DbContext
    {
        public HMSContext() : base("HMSContext")
        {

        }
        public DbSet<AccomodationType> AccomodationTypes { get; set; }
        public DbSet<AccomodationPackage> AccomodationPackages { get; set; }
        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}