using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class BaseController : Controller
    {
        public BaseController()
        {
            
        }

        public string GetCurrentUserName(){
            return HttpContext.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        }
    }
}