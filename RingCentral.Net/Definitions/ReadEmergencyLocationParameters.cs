namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readEmergencyLocation
    /// </summary>
    public class ReadEmergencyLocationParameters
    {
        /// <summary>
        ///     If true, the emergency addresses will be synchronized with the
        ///     external provider data
        /// </summary>
        public bool? syncEmergencyAddress { get; set; }
    }
}