using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation
{
    public interface IContactInformationForUpdateVM : IViewModel
    {
        int Id { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}
