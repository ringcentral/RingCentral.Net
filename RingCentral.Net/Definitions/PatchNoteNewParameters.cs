namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation patchNoteNew
    /// </summary>
    public class PatchNoteNewParameters
    {
        /// <summary>
        ///     If true then note lock (if any) will be released upon request
        /// </summary>
        public bool? releaseLock { get; set; }
    }
}