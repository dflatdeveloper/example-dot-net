using MessageHandlerDataAccess;

namespace MessagingExample.Server.Factories
{
    public class PayloadFactory : IPayloadFactory
    {
        public Payload CreatePayload()
        {
            return new Payload {};

        }
    }
}
