﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsSystem.DAL.Models
{
    public class Department
    {
        public  int Id { get; set; }     
        public string? Name { get; set; } = string.Empty;

        public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();

        public Department(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;

        }
    }
}

