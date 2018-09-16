using AkhmerovHomework.Domain.Entites.Base.Interfaces;

namespace AkhmerovHomework.Domain.Entites.Base
{
    public class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
