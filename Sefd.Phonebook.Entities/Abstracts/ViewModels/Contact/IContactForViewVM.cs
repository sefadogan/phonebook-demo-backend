using Sefd.Phonebook.Core.Entities;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact
{
    public interface IContactForViewVM : IViewModel
    {
         string FirstName { get; set; }
         string LastName { get; set; }
         string CompanyName { get; set; }

         ICollection<IContactInformationForViewVM> ContactInformations { get; set; }
    }
}
