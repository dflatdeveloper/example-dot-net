using MessageHandlerDataAccess;
using Microsoft.AspNetCore.Mvc;

namespace MessagingExample.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : Controller
    {
       
        private readonly ILogger<MessageController> _logger;

        public MessageController(ILogger<MessageController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "CreateMessage")]
        public IActionResult Create(string data1, string data2)
        {
            return null;
        }

        [HttpGet(Name ="GetMessage")]
        public IEnumerable<Payload> Get()
        {
            return null;
        }
    }
}
