using Sefd.Phonebook.Core.Entities;
using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;

namespace Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation
{
    public interface IContactInformationForViewDto : IDto
    {
        int ContactId { get; set; }
        string Phone { get; set; }
        string Email { get; set; }

        IContactForViewDto Contact { get; set; }
    }
}
