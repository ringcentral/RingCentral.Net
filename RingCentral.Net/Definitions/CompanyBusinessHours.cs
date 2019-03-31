namespace RingCentral
{
    public class CompanyBusinessHours
    {
        /// <summary>
        /// Canonical URI of a business-hours resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Schedule when an answering rule is applied
        /// </summary>
        public CompanyBusinessHoursScheduleInfo schedule;
    }
}