namespace RingCentral
{
    public class CreateUserEmergencyLocationRequest
    {
        /// <summary>
        ///     Name of a new personal emergency response location
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public LocationUpdatesEmergencyAddressInfoRequest address { get; set; }
    }
}