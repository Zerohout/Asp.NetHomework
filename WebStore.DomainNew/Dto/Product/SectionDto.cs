using WebStore.DomainNew.Entities.Base.Interfaces;

namespace WebStore.DomainNew.Dto.Product
{
    public class SectionDto : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
