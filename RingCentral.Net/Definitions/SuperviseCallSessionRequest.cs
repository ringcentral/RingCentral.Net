namespace RingCentral
{
    public class SuperviseCallSessionRequest
    {
        /// <summary>
        /// Supervising mode
        /// Required
        /// Enum: Listen
        /// </summary>
        public string mode;

        /// <summary>
        /// Internal identifier of a supervisor's device
        /// Required
        /// </summary>
        public string deviceId;

        /// <summary>
        /// Extension number of a user that will be monitored
        /// Required
        /// </summary>
        public string extensionNumber;
    }
}