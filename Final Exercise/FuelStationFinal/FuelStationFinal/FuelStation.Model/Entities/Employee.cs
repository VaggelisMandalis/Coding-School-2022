using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Entities.Enums;

namespace FuelStation.Models.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; } = DateTime.Now;
        public DateTime? HireDateEnd { get; set; }
        [Range(typeof(decimal), "0", "10000")]
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool Fired { get; set; }
        //Relations
        public List<Transaction> Transactions { get; set; }
    }
}
