﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsSystem.DAL.Models;

namespace TicketsSystem.DAL.Repo.DepartmentsRepo
{
    public interface IDepartmentsRepo
    {
        IEnumerable<Department> GetAll();
    }
}
