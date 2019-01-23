namespace RingCentral
{
    public class MeetingScheduleResource : Serializable
    {
        public string startTime;
        public long? durationInMinutes;
        public TimezoneResource timeZone;
    }
}