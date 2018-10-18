using WebStore.DomainNew.ViewModel.Order;

namespace WebStore.DomainNew.ViewModel.Cart
{
    public class DetailsViewModel
    {
        public CartViewModel CartViewModel { get; set; }

        public OrderViewModel OrderViewModel { get; set; }
    }
}
