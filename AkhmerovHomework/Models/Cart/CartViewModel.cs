using AkhmerovHomework.Models.Product;
using System.Collections.Generic;
using System.Linq;

namespace AkhmerovHomeWork.Models.Cart
{
    public class CartViewModel
    {
        public Dictionary<ProductViewModel, int> Items { get; set; }

        public int ItemsCount
        {
            get
            {
                return Items?.Sum(x => x.Value) ?? 0;
            }
        }
    }
}
