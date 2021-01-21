using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeNongPhanManhHung_HRM.Models
{
    public class HRMDbContext : DbContext
    {
        public HRMDbContext(DbContextOptions<HRMDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
