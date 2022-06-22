using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee: Entity.Entity
    {
        [Required]
        public string CompanyEmployeeId { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Phone { get; set; }

        public Employee? Superior { get; set; }

        [Required]
        public Department Department { get; set; }
    }
}
