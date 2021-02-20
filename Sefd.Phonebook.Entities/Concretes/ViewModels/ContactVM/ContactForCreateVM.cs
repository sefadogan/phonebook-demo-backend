using Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact;
using Sefd.Phonebook.Entities.Concretes.ViewModels.ContactInformation;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Concretes.ViewModels.Contact
{
    public class ContactForCreateVM : IContactForCreateVM
    {
        public ContactForCreateVM()
        {
            ContactInformations = new List<ContactInformationForCreateVM>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public List<ContactInformationForCreateVM> ContactInformations { get; set; }
    }
}
