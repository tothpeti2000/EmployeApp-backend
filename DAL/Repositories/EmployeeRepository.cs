using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EmployeeRepository
    {
        private readonly EmployeeContext db;

        public EmployeeRepository(EmployeeContext db)
        {
            this.db = db;
        }
    }
}
