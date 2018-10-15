using System.Collections.Generic;
using System.Linq;
using WebStore.DomainNew.ViewModel.Product;

namespace WebStore.DomainNew.ViewModel.Cart
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
