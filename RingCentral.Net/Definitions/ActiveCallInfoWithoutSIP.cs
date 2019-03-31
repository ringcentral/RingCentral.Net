namespace RingCentral
{
    public class ActiveCallInfoWithoutSIP
    {
        /* Internal identifier of a call */
        public string id;

        /* Call direction */
        // Enum: Inbound, Outbound
        public string direction;

        /* Phone number or extension number of a caller. For GCM transport type '_from' property should be used */
        public string from;

        /* Name of a caller */
        public string fromName;

        /* Phone number or extension number of a callee */
        public string to;

        /* Name of a callee */
        public string toName;

        /* Time when the call is actually started */
        public string startTime;

        /* Telephony call status */
        // Enum: NoCall, CallConnected, Ringing, OnHold, ParkedCall
        public string telephonyStatus;

        /* Internal identifier of a call session */
        public string sessionId;

        /* Type of call termination. Supported for calls in 'NoCall' status. If the returned termination type is 'intermediate' it means the call is not actually ended, the connection is established on one of the devices */
        // Enum: final, intermediate
        public string terminationType;
    }
}