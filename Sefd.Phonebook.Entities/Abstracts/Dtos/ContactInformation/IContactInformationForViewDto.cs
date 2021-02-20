﻿using Sefd.Phonebook.Core.Entities;

namespace Sefd.Phonebook.Entities.Abstracts.Dtos.ContactInformation
{
    public interface IContactInformationForViewDto : IDto
    {
        int ContactId { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}
