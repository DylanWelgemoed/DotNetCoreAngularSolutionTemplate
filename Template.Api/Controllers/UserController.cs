using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Template.Business.Services;
using Template.Interface.Repositories;

namespace Template.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserService userService;

        public UserController(IUserRepository userRepository)
        {
            userService = new UserService(userRepository);
        }

        [HttpGet]
        [Route("{userName}")]
        [Authorize]
        public IActionResult GetUser(string userName)
        {
            return Ok(userService.GetUser(userName));
        }
    }
}