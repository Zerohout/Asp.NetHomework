using AkhmerovHomeWork1.Domain.Entities.Base;
using AkhmerovHomeWork1.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomeWork1.Domain.Entities
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
