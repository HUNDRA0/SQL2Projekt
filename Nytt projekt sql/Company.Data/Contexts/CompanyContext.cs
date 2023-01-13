using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace Company.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public DbSet<Organization> Companys => Set<Organization>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Employee_Position> EmployeePositions => Set<Employee_Position>();
        public DbSet<Position> Positions => Set<Position>();


        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        { }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee_Position>().HasKey(ab => new { ab.EmployeeId, ab.PositionId });
            base.OnModelCreating(builder);   
            SeedData(builder);
        }
        private void SeedData(ModelBuilder builder)
        {
            var organizations = new List<Organization>
        {
            new Organization
            {
                Id = 1,
                CompanyName="Tesla",
                CompanyIdentityNumber = 123456,
            },
            new Organization
            {
                Id = 2,
                CompanyName="Apple",
                CompanyIdentityNumber = 654321,
            }
        };
            builder.Entity<Organization>().HasData(Companys);

            var employees = new List<Employee>
        {
            new Employee
            {
                Id=1,
                DepartmentId=1,
                FirstName="Mario",
                LastName="Youssef",
                Salary=30000,
                Union=true,
            },
            new Employee
            {
                Id=2,
                DepartmentId=3,
                FirstName="Johnny",
                LastName="Aho",
                Salary=40000,
                Union=true,
            },
            new Employee
            {
                Id=3,
                DepartmentId=4,
                FirstName="Jacob",
                LastName="Ercan",
                Salary=50000,
                Union=true,
            },
            new Employee
            {
                Id=4,
                DepartmentId=4,
                FirstName="Robin",
                LastName="Amoun",
                Salary=50000,
                Union=false,
            },
        };
            builder.Entity<Employee>().HasData(Employees);

            var avdelnings = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    CompanyId=1,
                    DepartmentName="Engineer",

                },
                new Department
                {
                    Id = 2,
                    CompanyId=2,
                    DepartmentName="RnD",

                },
                new Department
                {
                    Id = 3,
                    CompanyId=2,
                    DepartmentName="Doctor",

                },
                new Department
                {
                    Id = 4,
                    CompanyId=1,
                    DepartmentName="Cleaner",

                },

            };
            builder.Entity<Department>().HasData(Departments);

            var positions = new List<Position>
            {
                new Position
                {
                    Id=1,
                    PositionName="Doctor",
                },
                new Position
                {
                    Id=2,
                    PositionName="Engineer",
                },
                new Position
                {
                    Id=3,
                    PositionName="CEO",
                },
                new Position
                {
                    Id=4,
                    PositionName="RnD",
                },
            };
            builder.Entity<Position>().HasData(Positions);

            var employee_Positions = new List<Employee_Position>
            {
                new Employee_Position
                {
                    
                    EmployeeId=1,
                    PositionId=1,
                },
                new Employee_Position
                {
                    
                    EmployeeId=1,
                    PositionId=2,
                },
                new Employee_Position
                {
                    
                    EmployeeId=2,
                    PositionId=2,
                },
                new Employee_Position
                {
                    
                    EmployeeId=3,
                    PositionId=4,
                },
            };
            builder.Entity<Employee_Position>().HasData(EmployeePositions);




        }

    }
}
