using Sefd.Phonebook.Core.Entities;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact;

namespace Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation
{
    public interface IContactInformationForViewVM : IViewModel
    {
        int Id { get; set; }
        int ContactId { get; set; }
        string Phone { get; set; }
        string Email { get; set; }

        IContactForViewVM Contact { get; set; }
    }
}
