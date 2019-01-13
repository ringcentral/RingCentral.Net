using Newtonsoft.Json;

namespace RingCentral
{
    public class MeetingScheduleResource : Serializable
    {
        public string startTime;
        public int? durationInMinutes;
        public TimezoneResource timeZone;
    }
}