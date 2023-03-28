namespace RingCentral
{
    /// <summary>
    ///     Fax receiver
    /// </summary>
    public class FaxReceiver
    {
        /// <summary>
        ///     Phone number in E.164 format
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Name of the receiver
        /// </summary>
        public string name { get; set; }
    }
}