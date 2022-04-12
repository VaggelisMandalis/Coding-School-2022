using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationFinal.Shared.ViewModels
{
    public class CustomerListViewModel
    {
        public Guid ID { get; set; }= Guid.NewGuid();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
    }
    public class CustomerEditViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }
    }
}
