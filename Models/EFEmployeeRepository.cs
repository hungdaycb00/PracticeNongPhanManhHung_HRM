using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeNongPhanManhHung_HRM.Models
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private HRMDbContext context;

        public EFEmployeeRepository(HRMDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employees => context.Employees;
    }
}
