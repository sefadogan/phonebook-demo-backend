using Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Concretes.ViewModels.Contact
{
    public class ContactForViewVM : IContactForViewVM
    {
        public int ContactInformationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public ICollection<IContactInformationForViewVM> ContactInformations { get; set; }
    }
}
