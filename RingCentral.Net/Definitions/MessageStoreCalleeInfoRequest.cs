namespace RingCentral
{
    public class MessageStoreCalleeInfoRequest
    {
        /// <summary>
        /// Phone number in E.164 format
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// Name of the callee
        /// </summary>
        public string name { get; set; }
    }
}