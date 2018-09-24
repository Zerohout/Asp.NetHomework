using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AkhmerovHomework.Domain.Entities.Base;
using AkhmerovHomework.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomework.Domain.Entities
{
    public class Section : NamedEntity, IOrderedEntity
    {
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual Section ParentSection { get; set; }

        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
