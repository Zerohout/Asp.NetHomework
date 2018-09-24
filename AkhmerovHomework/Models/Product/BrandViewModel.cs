using AkhmerovHomework.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomework.Models.Product
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductsCount { get; set; }
        public int Order { get; set; }
    }
}
