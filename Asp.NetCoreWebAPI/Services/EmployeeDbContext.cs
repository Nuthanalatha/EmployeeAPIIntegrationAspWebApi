﻿using Asp.NetCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreWebAPI.Services
{
    public class EmployeeDbContext : DbContext {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) {

        }
        //only one type is present in our project as of now
        public DbSet<Employee> employee { get; set; }

    }
    
}

