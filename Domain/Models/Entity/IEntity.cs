﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entity
{
    public interface IEntity
    {
        long Id { get; set; }
        string Name { get; set; }

        //bool Active { get; set; }
    }
}
