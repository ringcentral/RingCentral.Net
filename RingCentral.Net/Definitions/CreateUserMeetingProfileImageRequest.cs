namespace RingCentral
{
    /// <summary>
    ///     Request body for operation createUserMeetingProfileImage
    /// </summary>
    public class CreateUserMeetingProfileImageRequest
    {
        /// <summary>
        ///     Profile image file size cannot exceed 2Mb. Supported formats are: JPG/JPEG, GIF and PNG
        ///     Required
        /// </summary>
        public Attachment profilePic { get; set; }
    }
}