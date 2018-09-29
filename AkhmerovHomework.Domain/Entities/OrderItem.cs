using AkhmerovHomework.Domain.Entities.Base;

namespace AkhmerovHomework.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
