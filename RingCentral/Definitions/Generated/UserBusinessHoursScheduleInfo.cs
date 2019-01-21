using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class UserBusinessHoursScheduleInfo : Serializable
    {
        // Weekly schedule
        public WeeklyScheduleInfo weeklyRanges;
    }
}