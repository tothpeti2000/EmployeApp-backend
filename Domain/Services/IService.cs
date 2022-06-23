using Domain.Models.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    // T1 ~ Model type
    // T2 ~ Corresponding DTO type
    public interface IService<T1, T2>
    {
        Task<T1?> GetByIdAsync(long Id);
        Task<PagedResponse<T1>> Query(Expression<Func<T1, bool>> predicate);
        Task<T1> AddAsync(T2 entity);
        Task<T1> UpdateAsync(T2 entity);
        Task<bool> DeleteByIdAsync(long Id);
    }
}
