using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject
{
    public partial class Order
    {
        public Order()
        {
            OrderComboDetails = new HashSet<OrderComboDetail>();
            OrderProductDetails = new HashSet<OrderProductDetail>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public decimal Total { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrdeDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
        public string Paymentmethod { get; set; }
        public string PaymentStatus { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderComboDetail> OrderComboDetails { get; set; }
        public virtual ICollection<OrderProductDetail> OrderProductDetails { get; set; }
    }
}
