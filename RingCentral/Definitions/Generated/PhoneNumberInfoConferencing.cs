namespace RingCentral
{
    public class PhoneNumberInfoConferencing : Serializable
    {
        // Information on a home country of a conference phone number
        public GetCountryInfoConferencing country;

        // 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
        public bool? @default;

        // 'True' if the greeting message is played on this number
        public bool? hasGreeting;

        // Location (city, region, state) of a conference phone number
        public string location;

        // Dial-in phone number to connect to a conference
        public string phoneNumber;
    }
}