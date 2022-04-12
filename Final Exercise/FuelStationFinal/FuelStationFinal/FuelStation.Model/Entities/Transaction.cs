using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Entities.Enums;

namespace FuelStation.Models.Entities
{
    [Serializable]
    public class Transaction:BaseEntity

    {
        public DateTime Date { get; set; }=DateTime.Now;
        public Guid EmployeeID { get; set; }
        public Guid CustomerID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalValue { get; set; }
        //Relations
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }

    }
}
