using MessageHandlerDataAccess;
using MessagingExample.Server.Factories;
using Microsoft.AspNetCore.Mvc;

namespace MessagingExample.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController(ILogger<MessageController> logger, ServiceBrokerContext dbContext, IPayloadFactory payloadFactory) : Controller
    {
        [HttpPost(Name = "createpayload")]
        public IActionResult Create(string content)
        {
            logger.LogInformation($"Creating new payload with content: {content}");


            var payload = payloadFactory.CreatePayload();

            payload.Content = content;  

            dbContext.Add(payload);
            dbContext.SaveChanges();

            return new OkResult();
        }

        [HttpGet(Name ="payloads")]
        public IEnumerable<Payload> Get()
        {
            logger.LogInformation("Getting Payloads");
            return dbContext.Payloads;
        }

        [HttpGet(Name = "payload")]
        public Payload? GetPayload(int id)
        {
            logger.LogInformation($"Getting Payload id {id}");
            return dbContext.Payloads.Where(p => p.Id == id).DefaultIfEmpty(defaultValue: null).SingleOrDefault();

        }
    }
}
