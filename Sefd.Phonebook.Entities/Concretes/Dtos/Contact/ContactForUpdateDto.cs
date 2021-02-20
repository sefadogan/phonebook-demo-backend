using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;

namespace Sefd.Phonebook.Entities.Concretes.Dtos.Contact
{
    public class ContactForUpdateDto : IContactForUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
    }
}
