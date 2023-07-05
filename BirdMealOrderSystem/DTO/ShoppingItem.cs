using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShoppingItem
    {
        public ShoppingItem()
        {
        }

        string type { get; set; }
        int ItemId { get; set; }

        int quantity { get; set; }

        decimal unitPirce { get; set; }
        double discount { get; set; }
        string imgLink { get; set; }
        
    }
}
