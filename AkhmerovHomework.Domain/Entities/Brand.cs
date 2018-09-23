using System.Collections.Generic;
using AkhmerovHomework.Domain.Entities.Base;
using AkhmerovHomework.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomework.Domain.Entities
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
