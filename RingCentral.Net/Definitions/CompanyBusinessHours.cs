namespace RingCentral
{
    public class CompanyBusinessHours
    {
        /// <summary>
        ///     Canonical URI of a business-hours resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public CompanyBusinessHoursScheduleInfo schedule { get; set; }
    }
}