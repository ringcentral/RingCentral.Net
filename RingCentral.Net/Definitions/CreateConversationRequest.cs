namespace RingCentral
{
    public class CreateConversationRequest
    {
        /// <summary>
        ///     Identifier(s) of chat member(s). The maximum supported number of IDs is 15. User's own ID is optional. If `members`
        ///     section is omitted then 'Personal' chat will be returned
        ///     Required
        /// </summary>
        public CreateConversationRequestMembers[] members { get; set; }
    }
}