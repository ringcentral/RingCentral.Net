namespace RingCentral
{
    public class MakeRingOutRequest
    {
        /// <summary>
        /// Phone number of the caller. This number corresponds to the 1st leg of the RingOut call. This number can be one of user's configured forwarding numbers or arbitrary number
        /// Required
        /// </summary>
        public MakeRingOutCallerInfoRequestFrom from;

        /// <summary>
        /// Phone number of the called party. This number corresponds to the 2nd leg of a RingOut call
        /// Required
        /// </summary>
        public MakeRingOutCallerInfoRequestTo to;

        /// <summary>
        /// The number which will be displayed to the called party
        /// </summary>
        public MakeRingOutCallerInfoRequestTo callerId;

        /// <summary>
        /// The audio prompt that the calling party hears when the call is connected
        /// </summary>
        public bool? playPrompt;

        /// <summary>
        /// Optional. Dialing plan country data. If not specified, then extension home country is applied by default
        /// </summary>
        public MakeRingOutCoutryInfo country;
    }
}