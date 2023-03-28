namespace RingCentral
{
    public class GetUserBusinessHoursResponse
    {
        /// <summary>
        ///     Canonical URI of a business-hours resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public ScheduleInfoUserBusinessHours schedule { get; set; }
    }
}