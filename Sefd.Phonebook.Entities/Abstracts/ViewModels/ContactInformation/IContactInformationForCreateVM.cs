using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.ViewModels.ContactInformation
{
    public interface IContactInformationForCreateVM : IViewModel
    {
        string Phone { get; set; }
        string Email { get; set; }
    }
}
