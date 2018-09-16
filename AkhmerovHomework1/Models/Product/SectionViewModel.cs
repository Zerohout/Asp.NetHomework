using AkhmerovHomeWork1.Domain.Entities.Base.Interfaces;
using System.Collections.Generic;

namespace AkhmerovHomework1.Models.Product
{
    public class SectionViewModel : INamedEntity, IOrderedEntity
    {
        public SectionViewModel()
        {
            ChildSections = new List<SectionViewModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public List<SectionViewModel> ChildSections { get; set; }

        public SectionViewModel ParentSection { get; set; }
    }
}
