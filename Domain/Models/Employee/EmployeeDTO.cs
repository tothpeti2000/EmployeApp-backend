using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Employee
{
    public class EmployeeListItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }

        public long DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class EmployeeFormData
    {
        public string Name { get; set; }
        public string Position { set; get; }
        public string Phone { set; get; }
        public long? SuperiorId { get; set; }
        public long DepartmentId { get; set; }

        public string UserName { get; set; }
        public string Password { set; get; }
    }
}
