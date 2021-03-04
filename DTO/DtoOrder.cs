using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public partial class DtoOrder
    {
        public DtoOrder()
        {
            //Orderdetails = new HashSet<Orderdetail>();
        }

        public int CustomerNumber { get; set; }

        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string Status { get; set; }
        
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal BuyPrice { get; set; }
        public int QuantityOrdered { get; set; }
        public decimal PriceEach { get; set; }
        public short OrderLineNumber { get; set; }

        public string Comments { get; set; }

    }

    public partial class DtoOrdersResponse
    {
        public DtoOrdersResponse()
        {

        }

        public List<DtoOrder> OrdersList {get; set;}

        public decimal TotalPrice { get; set; }
    }

}
