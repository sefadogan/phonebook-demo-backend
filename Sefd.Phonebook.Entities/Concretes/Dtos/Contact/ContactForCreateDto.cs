using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation;
using System;
using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Concretes.Dtos.Contact
{
    public class ContactForCreateDto : IContactForCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public ICollection<IContactInformationForCreateDto> ContactInformations { get; set; }
    }
}
