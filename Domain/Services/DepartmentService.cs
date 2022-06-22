using Domain.Models.Department;
using Domain.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class DepartmentService : IService<Department, DepartmentFormData>
    {
        public Task<Department> AddAsync(DepartmentFormData entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetByIdAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResponse<Department>> Query(Expression<Func<Department, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Department> UpdateAsync(DepartmentFormData entity)
        {
            throw new NotImplementedException();
        }
    }
}
