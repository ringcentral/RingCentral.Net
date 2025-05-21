namespace RingCentral
{
    /// <summary>
    ///     Request body for operation createGlipFileNew
    /// </summary>
    public class CreateGlipFileNewRequest
    {
        /// <summary>
        ///     File(s) - binary or multipart/form-data - to upload
        ///     Required
        /// </summary>
        public Attachment body { get; set; }
    }
}