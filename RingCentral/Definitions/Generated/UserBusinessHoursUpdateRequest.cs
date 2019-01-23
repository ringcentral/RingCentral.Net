using Newtonsoft.Json;

namespace RingCentral
{
    public class UserBusinessHoursUpdateRequest : Serializable
    {
        // Schedule when an answering rule is applied
        public UserBusinessHoursScheduleInfo schedule; // Required
    }
}