using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        //private readonly ILogger<BuggyController> logger;

        public BaseApiController(/*ILogger<BuggyController> logger*/)
        {
            //this.logger = logger;
        }
    }
}