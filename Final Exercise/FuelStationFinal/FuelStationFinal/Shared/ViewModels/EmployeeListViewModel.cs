using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Entities.Enums;

namespace FuelStationFinal.Shared.ViewModels
{
    public class EmployeeListViewModel
    {
        public Guid ID { get; set; }=Guid.NewGuid();

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; } = DateTime.Now;
        public DateTime? HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool Fired { get; set; }
    }

    public class EmployeeEditViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; } = DateTime.Now;
        public DateTime? HireDateEnd { get; set; }
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public bool Fired { get; set; }

    }
}
