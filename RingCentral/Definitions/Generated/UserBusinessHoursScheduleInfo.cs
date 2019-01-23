using Newtonsoft.Json;

namespace RingCentral
{
    public class UserBusinessHoursScheduleInfo : Serializable
    {
        // Weekly schedule
        public WeeklyScheduleInfo weeklyRanges;
    }
}