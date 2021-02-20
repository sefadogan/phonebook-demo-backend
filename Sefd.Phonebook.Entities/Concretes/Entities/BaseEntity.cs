using Sefd.Phonebook.Core.Entities;
using System;

namespace Sefd.Phonebook.Entities.Concretes.Entities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
