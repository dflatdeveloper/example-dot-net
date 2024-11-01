using Microsoft.EntityFrameworkCore;

namespace MessageHandlerDataAccess.Interfaces
{
    public interface IServiceBrokerContext
    {
        DbSet<Payload> Payloads { get; set; }
        void BulkInsertPayload(IEnumerable<Payload> payloads);
    }
}
