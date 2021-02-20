using Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation;

namespace Sefd.Phonebook.Entities.Concretes.Dtos.ContactInformation
{
    public class ContactInformationForUpdateDto : IContactInformationForUpdateDto
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
