﻿using Microsoft.EntityFrameworkCore;

namespace CFA_EmployeeDetails.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions options):base(options)
        {
            
        }
       public DbSet<Employee> Employees { get; set; }

    }
}
