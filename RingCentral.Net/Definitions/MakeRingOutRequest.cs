namespace RingCentral
{
    public class MakeRingOutRequest
    {
        /// <summary>
        /// Required
        /// </summary>
        public MakeRingOutCallerInfoRequestFrom from;

        /// <summary>
        /// Required
        /// </summary>
        public MakeRingOutCallerInfoRequestTo to;

        /// <summary>
        /// </summary>
        public MakeRingOutCallerIdInfo callerId;

        /// <summary>
        /// The audio prompt that the calling party hears when the call is connected
        /// </summary>
        public bool? playPrompt;

        /// <summary>
        /// </summary>
        public MakeRingOutCoutryInfo country;
    }
}