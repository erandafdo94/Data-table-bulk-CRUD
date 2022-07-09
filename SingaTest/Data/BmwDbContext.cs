using SingaTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SingaTest.Data
{
    public class BmwDbContext : DbContext
    {
        public BmwDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<MonthData> MonthData { get; set; }
        public DbSet<Serieses> Serieses { get; set; }

    }
}