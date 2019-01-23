namespace RingCentral
{
    public class AccountStatusInfo : Serializable
    {
        // A free-form user comment, describing the status change reason
        public string comment;

        // Type of suspension
        // Enum: Voluntarily, Involuntarily
        public string reason;

        // Date until which the account will get deleted. The default value is 30 days since current date
        public string till;
    }
}