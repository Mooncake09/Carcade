using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Carcade.Models
{
    public class CustomerPaymentModel
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }
        public decimal Sum { get; set; }
    }
}
