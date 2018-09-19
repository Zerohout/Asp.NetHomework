using System.ComponentModel.DataAnnotations.Schema;
using AkhmerovHomework.Domain.Entities.Base;
using AkhmerovHomework.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomework.Domain.Entities
{
    public class Product : NamedEntity , IOrderedEntity
    {
        public int Order { get; set; }
        public int SectionId { get; set; }

        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }

        public int? BrandId { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
    }
}
