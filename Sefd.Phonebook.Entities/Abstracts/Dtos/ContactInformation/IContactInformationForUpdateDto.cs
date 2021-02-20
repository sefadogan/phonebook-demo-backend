﻿using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation
{
    public interface IContactInformationForUpdateDto : IDto
    {
        int Id { get; set; }
        int ContactId { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}
