namespace RingCentral
{
    public class DeleteUserCallLogParameters
    {
        /// <summary>
        /// The end datetime for records deletion in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        /// </summary>
        public string dateTo;

        /// <summary>
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// </summary>
        public string[] type;

        /// <summary>
        /// </summary>
        public string[] direction;

        /// <summary>
        /// </summary>
        public string dateFrom;
    }
}