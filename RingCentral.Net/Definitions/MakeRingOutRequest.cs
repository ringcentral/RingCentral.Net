namespace RingCentral
{
    public class MakeRingOutRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public MakeRingOutCallerInfoRequestFrom from { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public MakeRingOutCallerInfoRequestTo to { get; set; }

        /// <summary>
        /// </summary>
        public MakeRingOutCallerIdInfo callerId { get; set; }

        /// <summary>
        ///     The audio prompt that the calling party hears when the call is connected
        /// </summary>
        public bool? playPrompt { get; set; }

        /// <summary>
        /// </summary>
        public MakeRingOutCoutryInfo country { get; set; }
    }
}