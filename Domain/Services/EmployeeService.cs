using Domain.Models.Employee;
using Domain.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class EmployeeService : IService<Employee, EmployeeFormData>
    {
        public Task<Employee> AddAsync(EmployeeFormData entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResponse<Employee>> Query(Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateAsync(EmployeeFormData entity)
        {
            throw new NotImplementedException();
        }
    }
}
