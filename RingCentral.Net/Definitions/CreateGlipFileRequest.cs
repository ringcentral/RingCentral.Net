namespace RingCentral
{
    /// <summary>
    ///     Request body for operation createGlipFile
    /// </summary>
    public class CreateGlipFileRequest
    {
        /// <summary>
        ///     The file (binary or multipart/form-data) to upload
        ///     Required
        /// </summary>
        public Attachment body { get; set; }
    }
}