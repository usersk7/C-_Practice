using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
    }
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }
    }
}