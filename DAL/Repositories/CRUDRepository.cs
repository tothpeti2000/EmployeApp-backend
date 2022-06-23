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
        protected EmployeeContext db;
        public DbSet<T> Items { get; }

        public CRUDRepository(EmployeeContext db)
        {
            this.db = db;
            Items = InitializeDbSet(db);
        }

        protected abstract DbSet<T> InitializeDbSet(EmployeeContext db);

        public async Task<T?> GetByIdAsync(long Id)
        {
            return await Items
                .FirstOrDefaultAsync(item => item.Id == Id);
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return Items
                .Where(predicate);
        }

        public async Task DeleteByIdAsync(long Id)
        {
            var item = await Items
                .FirstOrDefaultAsync(item => item.Id == Id);

            await db.SaveChangesAsync();
        }
    }
}
