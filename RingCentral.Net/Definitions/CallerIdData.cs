namespace RingCentral
{
    public class CallerIdData
    {
        /// <summary>
        ///     If 'PhoneNumber' value is specified, then a certain phone number
        ///     is shown as a caller ID when using this telephony feature. If 'Blocked'
        ///     value is specified, then a caller ID is hidden. The value 'CurrentLocation'
        ///     can be specified for 'RingOut' feature only
        ///     Default: PhoneNumber
        ///     Enum: PhoneNumber, Blocked, CurrentLocation
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CallerIdPhoneInfo phoneInfo { get; set; }
    }
}