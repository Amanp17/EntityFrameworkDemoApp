using EntityFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Data
{
    public class SeedData
    {
        public static void SeedDataDB(EmployeeContext context)
        {
            context.Database.EnsureCreated();    //It Ensures that Database For Context Already Exists

            if (context.Employee.Any())
            {
                return;   //Looks For Any Data in Employee DBSet
            }

            //Initializing Data
            var employees = new Employee[]
            {
                new Employee{FirstName="Bob",LastName="Wilson",Designation="Accounting",Age=32,Salary=50000},
                new Employee{FirstName="Mark",LastName="Mitchel",Designation="Human Resources",Age=26,Salary=48000},
                new Employee{FirstName="Parker",LastName="Chelse",Designation="Chartered Financial Analyst",Age=38,Salary=78000},
                new Employee{FirstName="George",LastName="Katie",Designation="Finance",Age=52,Salary=97000},
                new Employee{FirstName="Marie",LastName="Wood",Designation="Software Analyst",Age=31,Salary=65000},
                new Employee{FirstName="Lake",LastName="Marnus",Designation="Supply Chain and Logistics",Age=33,Salary=54000}
            };

            //Add Method Starts Tracking the Entities
            foreach(var employeeData in employees)
            {
                context.Employee.Add(employeeData);
            }
            context.SaveChanges();     //SaveChanges Method will makes all the Changes to Database
        }
    }
}
