namespace RingCentral
{
    public class DialInNumberResource
    {
        /// <summary>
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public string formattedNumber { get; set; }

        /// <summary>
        /// </summary>
        public string location { get; set; }

        /// <summary>
        /// </summary>
        public MeetingsCountryResource country { get; set; }
    }
}