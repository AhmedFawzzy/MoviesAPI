using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Dtos;

namespace MoviesAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _usermanager;
        public AccountController(UserManager<ApplicationUser> usermanager)
        {
            _usermanager = usermanager;
            
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = dto.UserName;
                user.Email = dto.Email;
               IdentityResult result = await _usermanager.CreateAsync(user, dto.Password);
                if (result.Succeeded)
                {
                    Ok("Seccess");
                }
                else
                    return BadRequest();
            }   return BadRequest(ModelState);

        
        
        }
    }
}
