using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class MakeRingOutRequest : Serializable
    {
        // Phone number of the caller. This number corresponds to the 1st leg of the RingOut call. This number can be one of user's configured forwarding numbers or arbitrary number
        public MakeRingOutCallerInfoRequestFrom from; // Required
        // Phone number of the called party. This number corresponds to the 2nd leg of a RingOut call
        public MakeRingOutCallerInfoRequestTo to; // Required
        // The number which will be displayed to the called party
        public MakeRingOutCallerInfoRequestTo callerId;
        // The audio prompt that the calling party hears when the call is connected
        public bool? playPrompt;
        // Optional. Dialing plan country data. If not specified, then extension home country is applied by default
        public MakeRingOutCoutryInfo country;
    }
}