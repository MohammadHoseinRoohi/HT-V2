using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practice4.Entities;

namespace Practice4.DbContextes
{
    public class LibraryDB : DbContext
    {
        public DbSet<Cooperative> Cooperatives { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}