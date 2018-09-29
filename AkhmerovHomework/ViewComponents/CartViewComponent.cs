using AkhmerovHomeWork.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AkhmerovHomeWork.ViewComponents
{ 
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartService _cartService;

        public CartViewComponent(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IViewComponentResult Invoke()
        {
            var cartView = _cartService.TransformCart();

            return View(cartView);
        }
    }
}
