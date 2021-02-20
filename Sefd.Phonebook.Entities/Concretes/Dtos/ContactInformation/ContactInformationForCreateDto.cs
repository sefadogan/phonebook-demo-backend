using Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation;
using System;

namespace Sefd.Phonebook.Entities.Concretes.Dtos.ContactInformation
{
    public class ContactInformationForCreateDto : IContactInformationForCreateDto
    {
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
