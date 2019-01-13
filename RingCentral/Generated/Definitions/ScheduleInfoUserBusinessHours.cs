using Newtonsoft.Json;

namespace RingCentral
{
    public class ScheduleInfoUserBusinessHours : Serializable
    {
        // Weekly schedule
        public WeeklyScheduleInfo weeklyRanges;
    }
}