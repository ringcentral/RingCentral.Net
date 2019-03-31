namespace RingCentral
{
    public class GetUserBusinessHoursResponse
    {
        /// <summary>
        /// Canonical URI of a business-hours resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Schedule when an answering rule is applied
        /// </summary>
        public ScheduleInfoUserBusinessHours schedule;
    }
}