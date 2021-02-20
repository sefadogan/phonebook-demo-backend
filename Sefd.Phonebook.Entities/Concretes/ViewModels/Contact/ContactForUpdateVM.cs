using Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact;

namespace Sefd.Phonebook.Entities.Concretes.ViewModels.Contact
{
    public class ContactForUpdateVM : IContactForUpdateVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
    }
}
