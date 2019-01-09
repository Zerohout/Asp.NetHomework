using WebStore.DomainNew.Entities.Base;

namespace WebStore.DomainNew.Dto.Order
{
    public class OrderItemDto : BaseEntity
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
