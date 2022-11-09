namespace RingCentral
{
    public class TMAddTeamMembersRequest
    {
        /// <summary>
        ///     Identifier(s) of chat member(s)
        ///     Required
        /// </summary>
        public TMAddTeamMembersRequestMembers[] members { get; set; }
    }
}