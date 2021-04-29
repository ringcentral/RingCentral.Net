namespace RingCentral
{
    public class TaskResultRecord
    {
        /// <summary>
        ///     Internal identifier of the created/updated element - wireless point or network switch
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Unique 48-bit identifier of the wireless access point complying with MAC address conventions. Returned only for 'Wireless Points Bulk Create' tasks
        /// </summary>
        public string bssid { get; set; }

        /// <summary>
        ///     Unique identifier of a network switch. Returned only for 'Switches Bulk Create' tasks
        /// </summary>
        public string chassisId { get; set; }

        /// <summary>
        ///     Operation status
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public TaskResultRecordErrorsInfo[] errors { get; set; }
    }
}