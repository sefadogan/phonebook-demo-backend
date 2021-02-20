using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sefd.Phonebook.Business.Abstract;
using Sefd.Phonebook.Entities.Abstracts.Dtos;
using Sefd.Phonebook.Entities.Abstracts.ViewModels;
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
            var result = await _contactService.GetList();
            if (!result.Success)
                return BadRequest(result.Message);

            var mappedContactVMs = _mapper.Map<ICollection<IContactForViewVM>>(result.Data);
            return Ok(mappedContactVMs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _contactService.GetById(id);
            if (!result.Success)
                return BadRequest(result.Message);

            var mappedContactVMs = _mapper.Map<IContactForViewVM>(result.Data);
            return Ok(mappedContactVMs);
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactForCreateVM contactForCreateVM)
        {
            var mappedContact = _mapper.Map<IContactDto>(contactForCreateVM);

            var result = await _contactService.AddAsync(mappedContact);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}
