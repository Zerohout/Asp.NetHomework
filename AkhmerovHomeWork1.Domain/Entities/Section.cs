using AkhmerovHomeWork1.Domain.Entities.Base;
using AkhmerovHomeWork1.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomeWork1.Domain.Entities
{
    public class Section : NamedEntity, IOrderedEntity
    {
        public int? ParentId { get; set; }

        public int Order { get; set; }
    }
}
