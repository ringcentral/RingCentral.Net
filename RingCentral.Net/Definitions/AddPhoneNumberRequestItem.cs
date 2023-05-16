namespace RingCentral
{
    public class AddPhoneNumberRequestItem
    {
        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix).
        ///     Wildcards are supported to pass large sets (for example 100 numbers);
        ///     only one phone number record must be passed in request in that case, for example '+1650123456*'
        ///     Required
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Only "Inventory" is supported now.
        ///     Later we may support other values like "ForwardedNumber" etc.
        ///     Required
        ///     Enum: Inventory
        /// </summary>
        public string usageType { get; set; }
    }
}