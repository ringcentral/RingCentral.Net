namespace RingCentral
{
    public class CreateUserMeetingProfileImageRequest
    {
        /// <summary>
        /// Profile image file size cannot exceed 2Mb. Supported formats are: JPG/JPEG, GIF and PNG
        /// </summary>
        public string profilePic { get; set; }
    }
}