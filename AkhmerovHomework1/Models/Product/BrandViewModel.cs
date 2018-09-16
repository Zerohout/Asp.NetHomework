using AkhmerovHomeWork1.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomework1.Models.Product
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public int ProductsCount { get; set; }
    }
}
