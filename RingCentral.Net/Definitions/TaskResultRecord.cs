namespace RingCentral
{
    public class TaskResultRecord
    {
        /// <summary>
        /// Element identifier of the created element specific for wireless access points creation
        /// </summary>
        public string bssid;

        /// <summary>
        /// Element identifier of the created element specific for network switches creation
        /// </summary>
        public string chassisId;

        /// <summary>
        /// Element identifier of the created element specific for switches and points update
        /// </summary>
        public string id;

        /// <summary>
        /// Operation status
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public TaskResultRecordErrorsInfo errors;
    }
}