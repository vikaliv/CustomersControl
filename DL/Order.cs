﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DL
{
    public partial class Order
    {
        public Order()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int CustomerNumber { get; set; }

        public virtual Customer CustomerNumberNavigation { get; set; }
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
