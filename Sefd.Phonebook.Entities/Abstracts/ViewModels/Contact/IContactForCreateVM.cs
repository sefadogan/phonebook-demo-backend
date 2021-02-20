using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact
{
    public interface IContactForCreateVM : IViewModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string CompanyName { get; set; }
    }
}
