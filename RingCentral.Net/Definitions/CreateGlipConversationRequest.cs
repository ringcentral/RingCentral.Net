namespace RingCentral
{
    public class CreateGlipConversationRequest
    {
        /// <summary>
        /// Identifier(s) of chat member(s). The maximum supported number of IDs is 15. User's own ID is optional. If `members` section is omitted then 'Personal' chat will be returned
        /// Required
        /// </summary>
        public object[] members;
    }
}