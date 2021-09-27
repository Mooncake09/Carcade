using System;
using System.ComponentModel.DataAnnotations;

namespace Carcade.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Sum { get; set; }
    }
}
