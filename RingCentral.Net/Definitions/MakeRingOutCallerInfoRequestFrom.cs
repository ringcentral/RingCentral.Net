namespace RingCentral
{
    // Phone number of the caller. This number corresponds to the 1st leg of the RingOut call. This number can be one of the user's configured forwarding numbers or an arbitrary number
    public class MakeRingOutCallerInfoRequestFrom
    {
        /// <summary>
        ///     Phone number in E.164 format
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Internal identifier of a forwarding number; returned in response as an 'id' field value. Can be specified instead
        ///     of the phoneNumber attribute
        /// </summary>
        public string forwardingNumberId { get; set; }
    }
}