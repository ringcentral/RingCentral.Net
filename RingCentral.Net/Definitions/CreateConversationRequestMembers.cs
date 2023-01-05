namespace RingCentral
{
    public class CreateConversationRequestMembers
    {
        /// <summary>
        ///     Internal identifier of a person
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Email of a person
        ///     Format: email
        /// </summary>
        public string email { get; set; }
    }
}