using API.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    //Type API Controller
    [ApiController]
    //Route attribute
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }
}