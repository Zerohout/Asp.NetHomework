using AkhmerovHomework.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomework.Domain.Entities.Base
{
    public class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
