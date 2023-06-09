﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsSystem.DAL.Models
{
    public class Ticket
    {

        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public Severity Severity { get; set; }

        public int DepartmentId { get; set; }  
        public Department? Department { get; set; }
        public ICollection<Developer> Developers { get; set; } = new HashSet<Developer>();

    }
}
