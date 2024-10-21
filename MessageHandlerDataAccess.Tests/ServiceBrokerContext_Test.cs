using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandlerDataAccess.Tests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public static class ServiceBrokerContext_Test
    {
        [Test]
        public static void Fetch_BrokerInstance_Test() { }
        [Test]
        public static void BuildPayload_Test() { }
        [Test]
        public static void SendPayload_Fetching_Connection_Test() { }

        public static void SendPayload_Pending_State_Result_Ignore_Test() { }

        public static void SendPayload_Pending_State_Result_Error_Test() { }

        public static void SendPayload_Pending_State_Result_Verbose_Test() { }

        public static void SendPayload_Pending_State_Result_Success_Test() { }

        public static void TxRxPayload_Pending_State_Request_Fetch_Header_Test() { }

        public static void TxRxPayload_Pending_State_Request_Add_Header_Test() { }

        public static void SendPayload_Pending_State_Request_IntegrateContent_Test() { }

        public static void SendPayload_Transmitting_State_Request_Test() { }

        public static void SendPayload_Transmitting_State_Response_Error_Test() { }
        
        public static void SendPayload_Transmitting_State_Reponse_Success_Test() { }

        public static void SendPayload_Transmitting_State_Reponse_Fetch_RetryManager_Test() { }

        public static void SendPayload_Transmitting_State_Reponse_Retry_Test() { }

        public static void SendPayload_Transmitting_State_Response_FailRetry_Test() { }

        public static void SendPayload_Close_State_Response_Fail_Test() { }

        public static void SendPayload_Close_State_Response_Success_NoRetry_Test() { }

        public static void SendPayload_Close_State_Response_Fail_RetryCount_Test() { }

        public static void SendPayload_Close_State_Response_Success_RetryCount_Test() { }

        public static void SendPayload_Close_State_Error_CloseConnection_Test() {  }

        public static void SendPayload_Close_State_Success_CloseConnection_Test() { }

        public static void ReceivePayload_Fetching_Connection_Test() { }

        public static void ReceivePayload_Pending_State_Result_NoOp_Test() { }

        public static void ReceivePayload_Pending_State_Result_Error_Test() { }

        public static void ReceivePayload_Pending_State_Result_Verbose_Test() { }

        public static void ReceivePayload_Pending_State_Result_Success_Test() { }

        public static void ReceivePayload_Pending_State_Receiving_Validate_PayloadSecurityManager_Test() { }

        public static void ReceivePayload_Pending_State_Receiving_IsolateContent_Test() { }

        public static void ReceivePayload_Received_State_Result_Success() { }


    }
}
