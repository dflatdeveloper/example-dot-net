using Microsoft.EntityFrameworkCore;

namespace MessageHandlerDataAccess
{
    public class ServiceBrokerContext : DbContext
    {
        public DbSet<Payload> Payloads { get; private set; }
        public DbSet<IEnumerable<Header>> Headers { get; private set; }
        public DbSet<Body> Body { get; private set; }
    }
}
