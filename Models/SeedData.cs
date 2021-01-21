using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeNongPhanManhHung_HRM.Models
{
    public class SeedData
    {
        public static void EnsurePopulate(IApplicationBuilder app)
        {
            HRMDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<HRMDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                   
                    new Employee
                    {
                        Name = "Marker",
                        Gender = "Male",
                        Birthday="11/1/1999",
                        Address = "USA",
                        PhoneNumber = "012344444"
                    },
                    new Employee
                    {
                        Name = "Jason Kevin",
                        Gender = "Male",
                        Birthday="10/1/1997",
                        Address = "USA",
                        PhoneNumber = "012322698"
                    },
                    new Employee
                    {
                        Name = "Elia",
                        Gender = "Female",
                        Birthday="11/2/1999",
                        Address = "England",
                        PhoneNumber = "0222215453"
                    },
                    new Employee
                    {
                        Name = "Hana",
                        Gender = "Female",
                        Birthday="19/9/1998",
                        Address = "Germance",
                        PhoneNumber = "012345999"
                    },
                    new Employee
                    {
                        Name = "John",
                        Gender = "Male",
                        Birthday="11/10/1988",
                        Address = "Canada",
                        PhoneNumber = "012347777"
                    },
                    new Employee
                    {
                        Name = "Emily",
                        Gender = "Female",
                        Birthday="11/3/1998",
                        Address = "Canada",
                        PhoneNumber = "012348787"
                    });
                context.SaveChanges();
            }
        }
    }
}
