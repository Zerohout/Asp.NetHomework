using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using WebStore.DomainNew.ViewModel.Cart;
using WebStore.Interfaces.Services;

namespace WebStore.Services.Cart
{
    public class CookiesCartStore : ICartStore
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _cartName;

        public DomainNew.ViewModel.Cart.Cart Cart
        {
            get
            {
                var cookie = _httpContextAccessor.HttpContext.Request.Cookies[_cartName];
                string json;
                DomainNew.ViewModel.Cart.Cart cart;

                if (cookie == null)
                {
                    cart = new DomainNew.ViewModel.Cart.Cart { Items = new List<CartItem>() };
                    json = JsonConvert.SerializeObject(cart);

                    _httpContextAccessor.HttpContext.Response.Cookies.Append(_cartName, json, new CookieOptions()
                    {
                        Expires = DateTime.Now.AddDays(1)
                    });
                    return cart;
                }

                json = cookie;
                cart = JsonConvert.DeserializeObject<DomainNew.ViewModel.Cart.Cart>(json);

                _httpContextAccessor.HttpContext.Response.Cookies.Delete(_cartName);

                _httpContextAccessor.HttpContext.Response.Cookies.Append(_cartName, json, new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(1)
                });

                return cart;
            }

            set
            {
                var json = JsonConvert.SerializeObject(value);

                _httpContextAccessor.HttpContext.Response.Cookies.Delete(_cartName);
                _httpContextAccessor.HttpContext.Response.Cookies.Append(_cartName, json, new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(1)
                });
            }
        }

        public CookiesCartStore(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _cartName = "cart" + (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated ? _httpContextAccessor.HttpContext.User.Identity.Name : "");
        }
    }
}
