namespace RingCentral
{
    public class TaskResultRecord
    {
        /// <summary>
        /// Internal identifier of the created/updated element - wireless point or network switch
        /// </summary>
        public string id;

        /// <summary>
        /// Unique 48-bit identifier of the wireless access point complying with MAC address conventions. Returned only for 'Wireless Points Bulk Create' tasks
        /// </summary>
        public string bssid;

        /// <summary>
        /// Unique identifier of a network switch. Returned only for 'Switches Bulk Create' tasks
        /// </summary>
        public string chassisId;

        /// <summary>
        /// Operation status
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public TaskResultRecordErrorsInfo errors;
    }
}