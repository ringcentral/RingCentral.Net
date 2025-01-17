namespace RingCentral
{
    /// <summary>
    ///     Voicemail owner information. Supported for shared voicemail messages only
    /// </summary>
    public class VoicemailOwnerResource
    {
        /// <summary>
        ///     Name of a voicemail owner
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }
    }
}