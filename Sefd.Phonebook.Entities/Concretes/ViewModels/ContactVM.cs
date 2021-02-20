using Sefd.Phonebook.Entities.Abstracts.ViewModels;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Concretes.ViewModels
{
    public class ContactVM : IContactVM
    {
        public int ContactInformationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public ICollection<IContactInformationVM> ContactInformations { get; set; }
    }
}
