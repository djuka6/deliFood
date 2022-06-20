using DeliFood.Domain.Model.DTO;
using DeliFood.Domain.Model.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliFood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            try
            {
                var response = _userService.Authenticate(model);
                return Ok(new { StatusCode = 200, Token = response });
            }
            catch (Exception e)
            {
                if (e.Message.Equals("Error with database connection."))
                {
                    // return BadRequest(new { StatusCode = 500, Message = e.Message });
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
                return BadRequest(new { StatusCode = 403, Message = e.Message });


            }
        }
    }
}
