using MessageHandlerDataAccess.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MessageHandlerDataAccess
{
    public class ServiceBrokerContext : DbContext, IServiceBrokerContext
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

        public void BulkInsertPayload(IEnumerable<Payload> payloads)
        {
            //create data record

            List<SqlDataRecord> sqlDataRecords = [];
                               
                
            payloads
                .ToList()
                .ForEach(payload =>
                {
                    var data = MessageHandlerBulkEntityBuilder.BuildPayloadDataRecord();

                    data.SetInt32(0, payload.Id ?? 0);
                    data.SetString(1, payload.Content);

                    sqlDataRecords.Add(data);

                });



            // Create a list of SqlDataRecord objects from your list of entities here

            using var connection = (SqlConnection)Database.GetDbConnection();

            using var command = connection.CreateCommand();

            command.Connection = connection;

            connection.Open();

            command.CommandText = "usp_InsertPayload";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("Payload", SqlDbType.Structured)
            {
                Value = sqlDataRecords,
                TypeName = "dbo.Payload_TT"
            });

            command.ExecuteNonQuery();
        }
    }
}
