using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrivateTransport.Models
{
    public class RouteDbContext : DbContext
    {
        public DbSet<Route> routes { get; set; }
        public RouteDbContext() : base("Route") { }
    }
}