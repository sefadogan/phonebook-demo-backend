using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact
{
    public interface IContactForUpdateVM : IViewModel
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string CompanyName { get; set; }
    }
}
