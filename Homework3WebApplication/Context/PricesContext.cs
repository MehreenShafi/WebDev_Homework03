using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Homework3WebApplication.Models;

namespace Homework3WebApplication.Context
{
    public class PricesContext : DbContext
    {
        public DbSet<Prices> Prices { get; set; }
    }
}