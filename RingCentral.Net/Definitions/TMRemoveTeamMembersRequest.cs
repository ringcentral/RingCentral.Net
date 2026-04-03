namespace RingCentral
{
    public class TMRemoveTeamMembersRequest
    {
        /// <summary>
        ///     Identifier(s) of chat members.
        ///     Required
        /// </summary>
        public TMRemoveTeamMembersRequestMembers[] members { get; set; }
    }
}