namespace RingCentral
{
    public class CallRecording
    {
        /// <summary>
        ///     Internal identifier of a call recording
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Call recording status
        /// </summary>
        public bool? active { get; set; }

        /// <summary>
        ///     Recording mode
        ///     Enum: Automatic, OnDemand
        /// </summary>
        public string mode { get; set; }

        /// <summary>
        ///     Recording view
        ///     Enum: Party, Session
        /// </summary>
        public string view { get; set; }
    }
}