namespace RingCentral
{
    public class EditGroupRequest
    {
        /// <summary>
        ///     List of users to be added to a team
        /// </summary>
        public string[] addedPersonIds { get; set; }

        /// <summary>
        ///     List of user email addresses to be added to a team (i.e. as guests)
        /// </summary>
        public string[] addedPersonEmails { get; set; }

        /// <summary>
        ///     List of users to be removed from a team
        /// </summary>
        public string[] removedPersonIds { get; set; }
    }
}