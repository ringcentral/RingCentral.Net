namespace RingCentral
{
    /// <summary>
    ///     Returned for the note being edited (locked) at the current moment. Information on the user editing the note
    /// </summary>
    public class LockedByInfo
    {
        /// <summary>
        ///     Internal identifier of the user editing the note
        /// </summary>
        public string id { get; set; }
    }
}