using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.ViewModels
{
    public interface IContactInformationVM : IViewModel
    {
        int ContactId { get; set; }
        string Phone { get; set; }
        string Email { get; set; }

        IContactVM Contact { get; set; }
    }
}
