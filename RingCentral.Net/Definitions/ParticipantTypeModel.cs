namespace RingCentral
{
    public class ParticipantTypeModel
    {
        /// <summary>
        ///     The type of the participant specified in invite or determined at join time
        ///     Required
        ///     Default: User
        ///     Enum: User, Room
        /// </summary>
        public string type { get; set; }
    }
}