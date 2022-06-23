using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Employee
{
    public class EmployeeListItem: Entity.Entity
    {
        [Required]
        public string Position { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public long DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }
    }

    public class EmployeeFormData: Entity.Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { set; get; }

        [Required]
        public string Phone { set; get; }

        public long? SuperiorId { get; set; }

        [Required]
        public long DepartmentId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { set; get; }
    }
}
