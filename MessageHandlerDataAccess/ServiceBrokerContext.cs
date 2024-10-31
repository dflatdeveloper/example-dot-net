using Microsoft.EntityFrameworkCore;

namespace MessageHandlerDataAccess
{
    public class ServiceBrokerContext : DbContext
    {
        public DbSet<Payload> Payloads { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payload>(b =>
                {
                    b.HasKey(e => e.Id);
                    b.Property(e => e.Id)
                        .ValueGeneratedOnAdd(); 
                }


            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
