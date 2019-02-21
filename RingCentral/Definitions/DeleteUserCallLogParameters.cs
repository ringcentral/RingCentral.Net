namespace RingCentral
{
    public class DeleteUserCallLogParameters
    {
        // The end datetime for records deletion in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        public string dateTo;

        public string phoneNumber;

        public string extensionNumber;

        public string[] type;

        public string[] direction;

        public string dateFrom;
    }
}