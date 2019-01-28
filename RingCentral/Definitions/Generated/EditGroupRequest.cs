namespace RingCentral
{
    public class EditGroupRequest
    {
        // List of users to be added to a team
        public string[] addedPersonIds;

        // List of user email addresses to be added to a team (i.e. as guests)
        public string[] addedPersonEmails;

        // List of users to be removed from a team
        public string[] removedPersonIds;
    }
}