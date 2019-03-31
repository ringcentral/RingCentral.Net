namespace RingCentral
{
    public class MakeRingOutCallerInfoRequestFrom
    {
        /// <summary>
        /// Phone number in E.164 format
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Internal identifier of a forwarding number; returned in response as an 'id' field value. Can be specified instead of the phoneNumber attribute
        /// </summary>
        public string forwardingNumberId;
    }
}