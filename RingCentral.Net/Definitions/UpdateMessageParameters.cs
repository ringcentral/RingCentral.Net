namespace RingCentral
{
    public class UpdateMessageParameters
    {
        /// <summary>
        /// </summary>
        public string dateFrom { get; set; }

        /// <summary>
        /// Enum: Fax, SMS, VoiceMail, Pager, Text, All
        /// </summary>
        public string type { get; set; }
    }
}