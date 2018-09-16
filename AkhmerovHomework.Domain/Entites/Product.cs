using AkhmerovHomework.Domain.Entites.Base;
using AkhmerovHomework.Domain.Entites.Base.Interfaces;

namespace AkhmerovHomework.Domain.Entites
{
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int SectionId { get; set; }

        public int? BrandId { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
    }
}
