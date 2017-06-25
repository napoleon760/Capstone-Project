using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Eticketer.Data.Entities;



namespace Eticketer.Core
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
