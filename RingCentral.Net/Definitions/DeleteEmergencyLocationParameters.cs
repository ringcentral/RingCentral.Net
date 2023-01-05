namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation deleteEmergencyLocation
    /// </summary>
    public class DeleteEmergencyLocationParameters
    {
        /// <summary>
        ///     Flag indicating that validation of emergency location(s) is required
        ///     before deletion
        /// </summary>
        public bool? validateOnly { get; set; }

        /// <summary>
        ///     Internal identifier of an emergency response location
        ///     that should be used instead of a deleted one.
        /// </summary>
        public string newLocationId { get; set; }
    }
}