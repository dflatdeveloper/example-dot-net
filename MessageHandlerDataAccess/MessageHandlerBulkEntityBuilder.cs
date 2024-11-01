using Microsoft.Data.SqlClient.Server;
using System.Data;

namespace MessageHandlerDataAccess
{

    //We do not want to expose this class outside of this assembly
    //This class is implementation specific
    //This is an example of when to new up internally versus using DI management
    internal static class MessageHandlerBulkEntityBuilder 
    {
        public static SqlDataRecord BuildPayloadDataRecord()
        {
            SqlDataRecord sqlDataRecord = new(
                [
                    new SqlMetaData("Id", SqlDbType.Int),
                    new SqlMetaData("Content", SqlDbType.NVarChar, -1)
                ]);

            return sqlDataRecord;   
        }
    }
}
