namespace RingCentral
{
    public class ConferencePhoneNumberInfo
    {
        /// <summary>
        ///     Dial-in phone number to connect to a conference
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     The value should be 'True' if the number is default for the conference. Default
        ///     conference number is a domestic number that can be set by user (otherwise
        ///     it is set by the system). Only one default number per country is allowed
        /// </summary>
        public bool? @default { get; set; }
    }
}