using AkhmerovHomework.Domain.Entites.Base;
using AkhmerovHomework.Domain.Entites.Base.Interfaces;

namespace AkhmerovHomework.Domain.Entites
{
    public class Section : NamedEntity, IOrderedEntity
    {
        public int? ParentId { get; set; }

        public int Order { get; set; }
    }
}
