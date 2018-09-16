using AkhmerovHomework.Domain.Entites.Base;
using AkhmerovHomework.Domain.Entites.Base.Interfaces;

namespace AkhmerovHomework.Domain.Entites
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
