namespace RingCentral
{
    public class GetLocationDeletionMultiResponse
    {
        /// <summary>
        /// Enum: Forbidden, Restricted, Allowed
        /// </summary>
        public string deletion;

        /// <summary>
        /// Enum: Forbidden, Allowed
        /// </summary>
        public string reassignment;

        /// <summary>
        /// </summary>
        public LocationDeletionInfo[] emergencyLocations;
    }
}