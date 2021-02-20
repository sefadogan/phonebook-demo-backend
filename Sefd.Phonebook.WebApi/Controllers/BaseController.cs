﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Sefd.Phonebook.WebApi.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        public readonly IMapper _mapper;

        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
