using System;
using System.Linq;

namespace Carcade.Models
{
    public static class SampleData
    {
        public static void Initialize(CarcadeContext context)
        {
            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer
                    {
                        CustomerName = "James Cain",
                    },
                    new Customer
                    {
                        CustomerName = "Robert Campbell"
                    },
                    new Customer
                    {
                        CustomerName = "Brian Johnson"
                    },
                    new Customer
                    {
                        CustomerName = "Adam Hudson"
                    },
                    new Customer
                    {
                        CustomerName = "James Smith"
                    },
                    new Customer
                    {
                        CustomerName = "Armando Daniels"
                    },
                    new Customer
                    {
                        CustomerName = "Scott Barnes"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Payments.Any())
            {
                context.Payments.AddRange(
                    new Payment()
                    {
                        CustomerId = 1,
                        PaymentDate = DateTime.Parse("12-01-2019"),
                        Sum = 12930
                    },
                    new Payment()
                    {
                        CustomerId = 2,
                        PaymentDate = DateTime.Parse("01-12-2017"),
                        Sum = 9300
                    },
                    new Payment()
                    {
                        CustomerId = 3,
                        PaymentDate = DateTime.Parse("14-09-2020"),
                        Sum = 1200
                    },
                    new Payment()
                    {
                        CustomerId = 4,
                        PaymentDate = DateTime.Parse("23-02-2015"),
                        Sum = 4553
                    },
                    new Payment()
                    {
                        CustomerId = 5,
                        PaymentDate = DateTime.Parse("05-07-2008"),
                        Sum = 8312
                    },
                    new Payment()
                    {
                        CustomerId = 6,
                        PaymentDate = DateTime.Parse("04-05-2010"),
                        Sum = 7000
                    },
                    new Payment()
                    {
                        CustomerId = 7,
                        PaymentDate = DateTime.Parse("15-10-2019"),
                        Sum = 10100
                    },
                    new Payment()
                    {
                        CustomerId = 3,
                        PaymentDate = DateTime.Parse("14-11-2020"),
                        Sum = 500
                    },
                    new Payment()
                    {
                        CustomerId = 6,
                        PaymentDate = DateTime.Parse("10-10-2011"),
                        Sum = 250
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}