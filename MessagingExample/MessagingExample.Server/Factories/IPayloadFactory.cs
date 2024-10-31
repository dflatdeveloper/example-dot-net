using MessageHandlerDataAccess;

namespace MessagingExample.Server.Factories
{
    public interface IPayloadFactory
    {
        Payload CreatePayload();
    }
}
