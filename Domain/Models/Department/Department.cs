using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Department
{
    public class Department: Entity.Entity
    {
        [Required]
        public string Abbreviation { get; set; }
    }
}
