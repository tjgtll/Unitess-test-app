using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Unitess_test_app.BLL.Services.IServices;

namespace Unitess_test_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger, IContactService contactService)
        {
            _logger = logger;
            _contactService = contactService;
        }

        //Include
        //[start, end]
        [HttpGet("get")]
        public IActionResult Get(int start, int end)
        {
            try
            {
                return Ok(_contactService.GetContactsRange(start, end));
            }
            catch (ArgumentOutOfRangeException e)
            {
                return Conflict(e.Message);
            }
            catch (Exception)
            {
                return BadRequest("Something went wrong");
            }
            
        }
    }
}
