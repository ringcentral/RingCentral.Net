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
        ///     Audio prompt that a calling party hears when a call
        ///     is connected
        /// </summary>
        public bool? playPrompt { get; set; }

        /// <summary>
        /// </summary>
        public MakeRingOutCountryInfo country { get; set; }
    }
}