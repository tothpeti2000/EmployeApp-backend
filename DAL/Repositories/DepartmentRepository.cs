using DAL.DbObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DepartmentRepository : CRUDRepository<DbDepartment>
    {
        public DepartmentRepository(EmployeeContext db): base(db)
        { }

        protected override DbSet<DbDepartment> InitializeDbSet(EmployeeContext db)
        {
            return db.Departments;
        }
    }
}
