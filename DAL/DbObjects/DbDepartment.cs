using Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbObjects
{
    public class DbDepartment
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}
