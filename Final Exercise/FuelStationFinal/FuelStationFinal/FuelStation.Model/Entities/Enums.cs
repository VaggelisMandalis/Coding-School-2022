using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Models.Entities
{
    public class Enums
    {
        public enum ItemType
        {
            Fuel,
            Product,
            Service
        }
        public enum EmployeeType 
        {
            Mananer,
            Staff,
            Cashier
        }
        public enum PaymentMethod
        {
            [Display(Name="Credit Card")]
            CreditCard,
            Cash
        }


    }
}
