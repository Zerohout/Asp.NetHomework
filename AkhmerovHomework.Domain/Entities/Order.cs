using System;
using System.Collections.ObjectModel;
using AkhmerovHomework.Domain.Entities.Base;

namespace AkhmerovHomework.Domain.Entities
{
    public class Order : NamedEntity
    {
        public virtual User User { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public Collection<OrderItem> OrderItems { get; set; }
    }
}
