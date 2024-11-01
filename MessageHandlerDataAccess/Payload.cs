namespace MessageHandlerDataAccess
{
    public class Payload : InsertablePayload
    {
        public bool ReceiverAcknowledged { get; set; } = false;
    }
}
