using Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation;

namespace Sefd.Phonebook.Entities.Concretes.ViewModels.ContactInformation
{
    public class ContactInformationForUpdateVM : IContactInformationForUpdateVM
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
