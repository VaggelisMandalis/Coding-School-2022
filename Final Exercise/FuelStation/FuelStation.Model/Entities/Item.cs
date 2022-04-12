using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FuelStation.Models.Entities.Enums;

namespace FuelStation.Models.Entities
{
    public class Item:BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        //Relations
        public List<TransactionLine> TransactionLines { get; set; }

    }
}
