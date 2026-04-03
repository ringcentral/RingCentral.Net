namespace RingCentral
{
    public class CallQueueOverflowSettings
    {
        /// <summary>
        ///     Call queue overflow status
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Extension subtype, if applicable.
        ///     For unrecognized subtypes the `Unknown` value is returned
        ///     Enum: VideoPro, VideoProPlus, DigitalSignageOnlyRooms, Unknown, Emergency
        /// </summary>
        public string subType { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueInfo[] items { get; set; }
    }
}