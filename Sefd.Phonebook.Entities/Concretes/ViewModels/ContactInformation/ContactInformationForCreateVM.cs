using Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation;

namespace Sefd.Phonebook.Entities.Concretes.ViewModels.ContactInformation
{
    public class ContactInformationForCreateVM : IContactInformationForCreateVM
    {
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
