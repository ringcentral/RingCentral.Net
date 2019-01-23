namespace RingCentral
{
    public class DialInNumberResource : Serializable
    {
        public string phoneNumber;
        public string formattedNumber;
        public string location;
        public CountryResource country;
    }
}