using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sefd.Phonebook.Business.Abstract;
using Sefd.Phonebook.Entities.Abstracts.Dtos;
using Sefd.Phonebook.Entities.Abstracts.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sefd.Phonebook.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : BaseController
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService, IMapper mapper) : base(mapper)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _contactService.GetList();
            if (!result.Success)
                return BadRequest(result.Message);

            var mappedContactVMs = _mapper.Map<ICollection<IContactDto>, ICollection<IContactVM>>(result.Data);
            return Ok(mappedContactVMs);
        }
    }
}
