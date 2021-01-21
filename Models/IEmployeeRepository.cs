using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeNongPhanManhHung_HRM.Models
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
