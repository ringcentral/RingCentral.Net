namespace RingCentral
{
    public class DeleteEmergencyLocationParameters
    {
        /// <summary>
        /// Internal identifier of a location that should be used instead of a deleted one
        /// </summary>
        public string newLocationId { get; set; }

        /// <summary>
        /// Flag indicating that validation of emergency location(s) is required before deletion
        /// </summary>
        public bool? validateOnly { get; set; }
    }
}