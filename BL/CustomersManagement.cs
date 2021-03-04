using DL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public static class CustomersManagement
    {
        public static List<DtoCustomer> GetCustomers()
        {
            List<DtoCustomer> customers = null;
            using (var context = new classicmodelsContext())
            {
                customers = context.Customers.Select(c => new DtoCustomer()
                {
                    CustomerNumber = c.CustomerNumber,
                    CustomerName = c.CustomerName,
                    ContactLastName = c.ContactLastName,
                    ContactFirstName = c.ContactFirstName,
                    Phone = c.Phone,
                    AddressLine1 = c.AddressLine1,
                    AddressLine2 = c.AddressLine2,
                    City = c.City,
                    State = c.State,
                    PostalCode = c.PostalCode,
                    Country = c.Country,
                    SalesRepEmployeeNumber = c.SalesRepEmployeeNumber,
                    CreditLimit = c.CreditLimit,
                    // I added this for deft checking
                    TotalPrices = (from o in c.Orders
                                    join od in context.Orderdetails on o.OrderNumber equals od.OrderNumber
                                    select od.PriceEach * od.QuantityOrdered).Sum(),                                   

                    TotalPayments = (from p in c.Payments select p.Amount).Sum()

            }).ToList();


            }

            return customers;
        }

        public static List<DtoOrder> GetCustomerOrders(int id)
        {
            List<DtoOrder> orders = null;

            using (var context = new classicmodelsContext())
            {
                var result = from o in context.Orders
                             join od in context.Orderdetails on o.OrderNumber equals od.OrderNumber
                             join p in context.Products on od.ProductCode equals p.ProductCode
                             where o.CustomerNumber == id
                             select new DtoOrder
                             {
                                 CustomerNumber = o.CustomerNumber,
                                 OrderNumber = o.OrderNumber,
                                 OrderDate = o.OrderDate,
                                 RequiredDate = o.RequiredDate,
                                 ShippedDate = o.ShippedDate,
                                 Status = o.Status,
                                 ProductCode = od.ProductCode,
                                 ProductName = p.ProductName,
                                 BuyPrice = p.BuyPrice,
                                 QuantityOrdered = od.QuantityOrdered,
                                 PriceEach = od.PriceEach,
                                 OrderLineNumber = od.OrderLineNumber,
                                 Comments = o.Comments
                             };

                orders = result.AsEnumerable().ToList();
                
            }            

            return orders;
        }

        public static Responses Update(DtoCustomer customer)
        {
            Responses result = Responses.Unknown;

            try
            {

                int id = customer.CustomerNumber;

                using (var context = new classicmodelsContext())
                {
                    Customer customerToUpdate = context.Customers.FirstOrDefault(c => c.CustomerNumber == id);

                    if (customerToUpdate != null)
                    {
                        customerToUpdate.CustomerName = customer.CustomerName;
                        customerToUpdate.ContactLastName = customer.ContactLastName;
                        customerToUpdate.ContactFirstName = customer.ContactFirstName;
                        customerToUpdate.Phone = customer.Phone;
                        customerToUpdate.AddressLine1 = customer.AddressLine1;
                        customerToUpdate.AddressLine2 = customer.AddressLine2;
                        customerToUpdate.City = customer.City;
                        customerToUpdate.State = customer.State;
                        customerToUpdate.PostalCode = customer.PostalCode;
                        customerToUpdate.Country = customer.Country;
                        customerToUpdate.CreditLimit = customer.CreditLimit;
                        customerToUpdate.SalesRepEmployeeNumber = customer.SalesRepEmployeeNumber;

                        result = context.SaveChanges() > 0 ? Responses.Success : Responses.NoChanges;
                    }
                    else
                    {
                        result = Responses.NoFound;
                    }
                }
            }
            catch (Exception ex)
            {
                result = Responses.Failed;
            }

            return result;
        }

        public static List<DtoCustomer> GetRiskCustomerts(decimal x)
        {
            List<DtoCustomer> customers = null;
            using (var context = new classicmodelsContext())
            {
                customers = (from c in context.Customers
                             where (from t in (from o in context.Orders
                                               join od in context.Orderdetails on o.OrderNumber equals od.OrderNumber
                                               where od.PriceEach > 0
                                               group od by o.CustomerNumber into g
                                               select new
                                               {
                                                   CustomerNumber = g.Key, /*totalPrices = g.Sum(od => od.PriceEach),*/
                                                   totalPaymentsPercent =
                                                   (from p in context.Payments
                                                    where p.CustomerNumber == g.Key
                                                    select p.Amount).Sum() * 100 / g.Sum(od => (od.PriceEach * od.QuantityOrdered))
                                               })
                                    where t.totalPaymentsPercent <= (100 - x)
                                    select t.CustomerNumber)
                             .Contains(c.CustomerNumber)
                             select new DtoCustomer()
                             {
                                 CustomerNumber = c.CustomerNumber,
                                 CustomerName = c.CustomerName,
                                 ContactLastName = c.ContactLastName,
                                 ContactFirstName = c.ContactFirstName,
                                 Phone = c.Phone,
                                 AddressLine1 = c.AddressLine1,
                                 AddressLine2 = c.AddressLine2,
                                 City = c.City,
                                 State = c.State,
                                 PostalCode = c.PostalCode,
                                 Country = c.Country,
                                 SalesRepEmployeeNumber = c.SalesRepEmployeeNumber,
                                 CreditLimit = c.CreditLimit,
                                 // I added this for deft checking
                                 TotalPrices = (from o in c.Orders
                                                join od in context.Orderdetails on o.OrderNumber equals od.OrderNumber
                                                select od.PriceEach * od.QuantityOrdered).Sum(),

                                 TotalPayments = (from p in c.Payments select p.Amount).Sum()

                             }).ToList();
            }

            return customers;
        }
    }
}
