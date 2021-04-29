namespace RingCentral
{
    public class PhoneNumberInfoConferencing
    {
        /// <summary>
        /// </summary>
        public GetCountryInfoConferencing country { get; set; }

        /// <summary>
        ///     'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
        /// </summary>
        public bool? @default { get; set; }

        /// <summary>
        ///     'True' if the greeting message is played on this number
        /// </summary>
        public bool? hasGreeting { get; set; }

        /// <summary>
        ///     Location (city, region, state) of a conference phone number
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Dial-in phone number to connect to a conference
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Indicates if the number is 'premium' (account phone number with the `ConferencingNumber` usageType)
        /// </summary>
        public bool? premium { get; set; }
    }
}