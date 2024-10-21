namespace MessageHandlerDataAccess
{
    public class Payload
    {
        public IEnumerable<Header>? Headers { get; private set; } = null;
        public ICustomData? Content { get; private set; } = null;
        public IPayloadSecurityManager? PayloadSecurityManager { get; private set; } = null;
    }
}
