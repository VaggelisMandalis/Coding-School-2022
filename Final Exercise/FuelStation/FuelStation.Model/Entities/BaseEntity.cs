using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Models.Entities
{
    public class BaseEntity
    {
        public Guid ID { get; set; } = Guid.NewGuid();
    }
}
