using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carcade.Models
{
    public class IndexViewModel
    {
        public IEnumerable<CustomerPaymentModel> CustomerPaymentModels { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
