namespace RingCentral
{
    public class PhoneNumberInfoConferencing
    {
        /// <summary>
        /// Information on a home country of a conference phone number
        /// </summary>
        public GetCountryInfoConferencing country;

        /// <summary>
        /// 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
        /// </summary>
        public bool? @default;

        /// <summary>
        /// 'True' if the greeting message is played on this number
        /// </summary>
        public bool? hasGreeting;

        /// <summary>
        /// Location (city, region, state) of a conference phone number
        /// </summary>
        public string location;

        /// <summary>
        /// Dial-in phone number to connect to a conference
        /// </summary>
        public string phoneNumber;
    }
}