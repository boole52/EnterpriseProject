﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class EnterpriseProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSQLlocalDb;Database=EnterpriseProject;Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
