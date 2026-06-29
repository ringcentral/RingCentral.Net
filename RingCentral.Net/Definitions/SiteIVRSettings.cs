namespace RingCentral
{
    public class SiteIVRSettings
    {
        /// <summary>
        /// </summary>
        public SiteIVRTopMenu topMenu { get; set; }

        /// <summary>
        ///     Number of attempts the IVR prompt will be played during a call before
        ///     the "NoInput" rule will be executed. For request payloads, unsupported
        ///     values return a `CMN-101` error.
        ///     Required
        ///     Format: int32
        ///     Enum: 1, 2, 3
        /// </summary>
        public long? promptRepeatCount { get; set; }

        /// <summary>
        /// </summary>
        public SiteIvrActions[] actions { get; set; }
    }
}