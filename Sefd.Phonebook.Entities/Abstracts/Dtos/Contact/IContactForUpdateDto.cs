using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.Dtos.Contact
{
    public interface IContactForUpdateDto : IDto
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string CompanyName { get; set; }
    }
}
