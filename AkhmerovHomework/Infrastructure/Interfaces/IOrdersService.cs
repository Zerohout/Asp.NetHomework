using AkhmerovHomework.Domain.Entities;
using AkhmerovHomeWork.Models.Cart;
using AkhmerovHomeWork.Models.Order;
using System.Collections.Generic;

namespace AkhmerovHomeWork.Infrastructure.Interfaces
{
    public interface IOrdersService
    {
        IEnumerable<Order> GetUserOrders(string userName);

        Order GetOrderById(int id);

        Order CreateOrder(OrderViewModel orderModel, CartViewModel transformCart, string userName);
    }
}
