using Domain.Models.Entity;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    // T ~ Type of items stored like DbEmployee or DbDepartment
    public abstract class CRUDRepository<T> : IRepository<T> where T : Entity
    {
        public DbSet<T> DbSet { get; }

        public CRUDRepository(EmployeeContext db)
        {
            DbSet = InitializeDbSet(db);
        }

        protected abstract DbSet<T> InitializeDbSet(EmployeeContext db);

        public async Task<T?> GetById(long Id)
        {
            return await DbSet
                .FirstOrDefaultAsync(item => item.Id == Id);
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return DbSet
                .Where(predicate);
        }

        public async Task DeleteByIdAsync(long Id)
        {
            var item = await DbSet
                .FirstOrDefaultAsync(item => item.Id == Id);

            DbSet.Remove(item);
        }
    }
}
