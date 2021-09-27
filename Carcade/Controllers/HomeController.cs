using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Carcade.Models;

namespace Carcade.Controllers
{
    public class HomeController : Controller
    {
        CarcadeContext db;
        public HomeController(CarcadeContext context)
        {
            db = context;
        }
        public IActionResult Index(int page = 1)
        {
            int pageSize = 3;
            var table = GetTable();
            var indexViewModel = GetPaginatedOutput(page, pageSize, table);
            return View(indexViewModel);
        }

        public IActionResult Filter(DateTime date, string name, int page = 1)
        {
            int pageSize = 3;
            var table = GetTable();
            if (!String.IsNullOrEmpty(name))
            {
                table = table.Where(row => row.Name.ToLower().Contains(name.ToLower()));
            }
            if(date != DateTime.MinValue)
            {
                table = table.Where(row => row.PaymentDate.Equals(date));
            }
            var indexViewModel = GetPaginatedOutput(page, pageSize, table);
            return View(indexViewModel);
        }

        private IndexViewModel GetPaginatedOutput(int currentPage, int pageSize, IEnumerable<CustomerPaymentModel> table)
        {
            var count = table.Count();
            table = table.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            var pageViewModel = new PageViewModel(count, currentPage, pageSize);
            return new IndexViewModel { CustomerPaymentModels = table, PageViewModel = pageViewModel };
        } 

        private IEnumerable<CustomerPaymentModel> GetTable()
        {
            var table = db.Payments.Join(db.Customers, payments => payments.CustomerId, customers => customers.Id,
                (payments, customers) => new CustomerPaymentModel
                {
                    Name = customers.CustomerName,
                    PaymentDate = payments.PaymentDate,
                    Sum = payments.Sum
                });
            return table.ToList();
        }
    }
}