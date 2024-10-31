namespace MessageHandlerDataAccess
{
    public record Payload
    {
        public int? Id { get; set; }
        public string? Content { get; set; } = null;
        public bool ReceiverAcknowledged { get; set; } = false;
    }
}
