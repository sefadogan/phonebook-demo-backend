using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sefd.Phonebook.Business.Abstract;
using Sefd.Phonebook.Entities.Abstracts.Dtos.Contact;
using Sefd.Phonebook.Entities.Abstracts.ViewModels.Contact;
using Sefd.Phonebook.Entities.Concretes.ViewModels.Contact;
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
            var result = await _contactService.GetListAsync();
            if (!result.Success)
                return BadRequest(result.Message);

            var mappedContactVMs = _mapper.Map<ICollection<IContactForViewVM>>(result.Data);
            return Ok(mappedContactVMs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _contactService.GetByIdAsync(id);
            if (!result.Success)
                return BadRequest(result.Message);

            var mappedContactVMs = _mapper.Map<IContactForViewVM>(result.Data);
            return Ok(mappedContactVMs);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactForCreateVM contactForCreateVM)
        {
            var mappedContact = _mapper.Map<IContactForCreateDto>(contactForCreateVM);

            var result = await _contactService.AddAsync(mappedContact);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _contactService.SoftDeleteAsync(id);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }
    }
}
