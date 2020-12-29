namespace RingCentral
{
    public class LocationDeletionInfo
    {
        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public string name;

        /// <summary>
        /// Identifies the possibility and status of emergency location deletion
        /// Enum: Failed, Completed, Forbidden, Restricted, Allowed
        /// </summary>
        public string deletion;

        /// <summary>
        /// </summary>
        public LocationDeletionErrorInfo errors;
    }
}