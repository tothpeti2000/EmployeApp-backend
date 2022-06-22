using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbObjects
{
    public class DbEmployee
    {
        public long Id { get; set; }
        public string CompanyEmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }

        public long SuperiorId { get; set; }
        public DbEmployee? Superior { get; set; }

        public long DepartmentId { get; set; }
        public DbDepartment Department { get; set; }
    }
}
