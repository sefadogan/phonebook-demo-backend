using Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation;

namespace Sefd.Phonebook.Entities.Concretes.ViewModels.ContactInformation
{
    public class ContactInformationForViewVM : IContactInformationForViewVM
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public IContactForViewVM Contact { get; set; }
    }
}
