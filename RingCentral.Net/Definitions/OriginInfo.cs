namespace RingCentral
{
    // Initial data of a call session || Session origin details
    public class OriginInfo
    {
        /// <summary>
        /// Session origin type
        /// Enum: Call, RingOut, RingMe, Conference, GreetingsRecording, VerificationCall, Zoom, CallOut
        /// </summary>
        public string type;
    }
}