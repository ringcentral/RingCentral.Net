namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation createGlipFile
    /// </summary>
    public class CreateGlipFileParameters
    {
        /// <summary>
        ///     Internal identifier of a group to which the post with attachment will be added to
        ///     Format: int64
        /// </summary>
        public long? groupId { get; set; }

        /// <summary>
        ///     Name of a file attached
        /// </summary>
        public string name { get; set; }
    }
}