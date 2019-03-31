namespace RingCentral
{
    public class GetCallSessionStatusParameters
    {
        /* The date and time of a call session latest change */
        public string timestamp;

        /* The time frame of awaiting for a status change before sending the resulting one in response */
        public string timeout;
    }
}