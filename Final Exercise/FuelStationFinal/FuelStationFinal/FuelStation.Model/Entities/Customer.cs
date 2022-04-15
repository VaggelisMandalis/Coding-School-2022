﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models.Entities
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; } = "A" + Guid.NewGuid().ToString("N").Substring(0, 10);
        public string Surname { get; set; }
        public string CardNumber { get; set; }
        //Relations
        public List<Transaction> Transactions { get; set; }
    }
}
