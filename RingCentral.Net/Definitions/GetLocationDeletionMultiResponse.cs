namespace RingCentral
{
    public class GetLocationDeletionMultiResponse
    {
        /// <summary>
        ///     Enum: Forbidden, Restricted, Allowed
        /// </summary>
        public string deletion { get; set; }

        /// <summary>
        ///     Enum: Forbidden, Allowed
        /// </summary>
        public string reassignment { get; set; }

        /// <summary>
        /// </summary>
        public LocationDeletionInfo[] emergencyLocations { get; set; }
    }
}