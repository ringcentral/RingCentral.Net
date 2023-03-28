namespace RingCentral
{
    public class UserBusinessHoursUpdateResponse
    {
        /// <summary>
        ///     Canonical URI of a business-hours resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public UserBusinessHoursScheduleInfo schedule { get; set; }
    }
}