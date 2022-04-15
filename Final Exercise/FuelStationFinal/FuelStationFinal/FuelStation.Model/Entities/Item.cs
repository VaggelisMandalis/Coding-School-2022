using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Range(typeof(decimal), "0", "1000")]
        public decimal Price { get; set; }
        [Range(typeof(decimal), "0", "1000")]
        public decimal Cost { get; set; }
        //Relations
        public List<TransactionLine> TransactionLines { get; set; }

    }
}
