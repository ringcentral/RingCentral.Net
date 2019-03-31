namespace RingCentral
{
    public class CreateMessageStoreReportRequest
    {
        /* Starting time for collecting messages. The default value equals to the current time minus 24 hours */
        public string dateFrom;

        /* Ending time for collecting messages. The default value is the current time */
        public string dateTo;
    }
}