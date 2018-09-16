using AkhmerovHomeWork1.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomework1.Models.Product
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Order { get; set; }
    }
}
