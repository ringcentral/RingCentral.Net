namespace RingCentral
{
    public class UnconditionalForwardingInfo
    {
        /// <summary>
        /// Phone number to which the call is forwarded. In addition to common e.164 format, the following number patterns are supported: 11xxxxxxxxxxx, 444xxxxxxxxxxx, 616xxxxxxxxxxx; where xxxxxxxxxxx is a phone number in e.164 format (without '+' sign)
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Event that initiates forwarding to the specified phone number
        /// Enum: HoldTimeExpiration, MaxCallers, NoAnswer
        /// </summary>
        public string action;
    }
}