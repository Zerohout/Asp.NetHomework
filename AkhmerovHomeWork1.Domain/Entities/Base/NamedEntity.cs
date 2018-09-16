using AkhmerovHomeWork1.Domain.Entities.Base.Interfaces;

namespace AkhmerovHomeWork1.Domain.Entities.Base
{
    public class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
