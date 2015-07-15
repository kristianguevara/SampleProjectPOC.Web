using SampleProjectPOC.Services.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleProjectPOC.Services
{
    public class MainContext : DbContext
    {
        public MainContext() : base("name=DefaultConnection"){ }

        public DbSet<Users> Users { get; set; }
    }
}