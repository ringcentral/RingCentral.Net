namespace RingCentral
{
    /// <summary>
    ///     Session origin details
    /// </summary>
    public class OriginInfo
    {
        /// <summary>
        ///     Session origin type
        ///     Enum: Call, RingOut, RingMe, Conference, GreetingsRecording, VerificationCall, Zoom, CallOut
        /// </summary>
        public string type { get; set; }
    }
}