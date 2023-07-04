using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject
{
    public partial class Combo
    {
        public Combo()
        {
            ComboDetails = new HashSet<ComboDetail>();
            OrderComboDetails = new HashSet<OrderComboDetail>();
        }

        public int ComboId { get; set; }
        public string ComboName { get; set; }
        public decimal Price { get; set; }
        public int Ratingavg { get; set; }
        [DiscountValid]
        public double Discount { get; set; }
        public string ComboDescription { get; set; }
        public bool ComboStatus { get; set; }

        public virtual ICollection<ComboDetail> ComboDetails { get; set; }
        public virtual ICollection<OrderComboDetail> OrderComboDetails { get; set; }
    }
}
