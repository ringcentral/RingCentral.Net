namespace RingCentral
{
    public class FaxRequestTo
    {
        /// <summary>
        ///     Phone number in E.164 (with '+' sign) format
        ///     Example: +18661234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Name of a fax recipient that will be listed on a fax cover page
        /// </summary>
        public string name { get; set; }
    }
}