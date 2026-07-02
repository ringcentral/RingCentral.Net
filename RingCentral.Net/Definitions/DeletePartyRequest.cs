namespace RingCentral
{
    public class DeletePartyRequest
    {
        /// <summary>
        ///     Keep conference session alive after deleting the party
        /// </summary>
        public bool? keepConferenceAlive { get; set; }
    }
}