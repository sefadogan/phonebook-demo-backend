using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.Dtos
{
    public interface IContactInformationDto : IDto
    {
        int ContactId { get; set; }
        string Phone { get; set; }
        string Email { get; set; }

        IContactDto Contact { get; set; }
    }
}
