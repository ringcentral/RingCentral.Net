namespace RingCentral
{
    public class SuperviseCallSessionRequest
    {
        /* Supervising mode */
        // Enum: Listen
        public string mode; // Required

        /* Internal identifier of a supervisor's device */
        public string deviceId; // Required

        /* Extension number of a user that will be monitored */
        public string extensionNumber; // Required
    }
}