namespace RingCentral
{
    public class LocationDeletionInfo
    {
        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Identifies the possibility and status of emergency location deletion
        ///     Enum: Failed, Completed, Forbidden, Restricted, Allowed
        /// </summary>
        public string deletion { get; set; }

        /// <summary>
        /// </summary>
        public LocationDeletionErrorInfo errors { get; set; }
    }
}