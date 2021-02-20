using Sefd.Phonebook.Entities.Abstracts.ViewModels;

namespace Sefd.Phonebook.Entities.Concretes.ViewModels
{
    public class ContactInformationVM : IContactInformationVM
    {
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public IContactVM Contact { get; set; }
    }
}
