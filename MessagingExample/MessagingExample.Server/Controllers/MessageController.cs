using MessageHandlerDataAccess;
using MessagingExample.Server.Factories;
using Microsoft.AspNetCore.Mvc;

namespace MessagingExample.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController(ILogger<MessageController> logger, ServiceBrokerContext dbContext, IPayloadFactory payloadFactory) : Controller
    {
        [HttpPost(Name = "payload")]
        public IActionResult Insert(string content)
        {
            logger.LogInformation($"Creating new payload with content: {content}");


            var payload = payloadFactory.CreatePayload();

            payload.Content = content;  

            dbContext.Add(payload);
            dbContext.SaveChanges();

            return new OkResult();
        }

        [HttpPost(Name = "payloads")]
        public IActionResult Insert(IEnumerable<string> contents)
        {
            logger.LogInformation($"Creating new payloads with {contents.Count()} records");

            List<Payload> payloads = [];

            foreach (var content in contents)
            {
                var payload = payloadFactory.CreatePayload();

                payload.Content = content;
            }

            dbContext.BulkInsertPayload(payloads);  

            return new OkResult();
        }

        [HttpGet(Name = "payload")]
        public Payload? Get(int id)
        {
            logger.LogInformation($"Getting Payload id {id}");
            return dbContext.Payloads.Where(p => p.Id == id).DefaultIfEmpty(defaultValue: null).SingleOrDefault();

        }

        [HttpGet(Name ="payloads")]
        public IEnumerable<Payload> Get()
        {
            logger.LogInformation("Getting Payloads");
            return dbContext.Payloads;
        }
    }
}
