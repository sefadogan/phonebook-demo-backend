using Sefd.Phonebook.Core.Entities;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Abstracts.ViewModels
{
    public interface IContactVM : IViewModel
    {
         int ContactInformationId { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
         string CompanyName { get; set; }

         ICollection<IContactInformationVM> ContactInformations { get; set; }
    }
}
