using System;

namespace DTO
{
    public partial class DtoCustomer
    {
        public DtoCustomer()
        {
            //Orders = new HashSet<Order>();
           // Payments = new HashSet<Payment>();
        }

        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int? SalesRepEmployeeNumber { get; set; }
        public decimal? CreditLimit { get; set; }

        public decimal TotalPrices { get; set; }
        public decimal TotalPayments { get; set; }
        public decimal PercnetGap
        {
            get
            {
                if (this.TotalPrices > 0)
                {
                    return (this.TotalPrices - this.TotalPayments) * 100 / this.TotalPrices;
                }

                return 0;
            }            
        }

        //public virtual Employee SalesRepEmployeeNumberNavigation { get; set; }
        //public virtual ICollection<Order> Orders { get; set; }
        //public virtual ICollection<Payment> Payments { get; set; }
    }
}
