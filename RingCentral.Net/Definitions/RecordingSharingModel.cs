namespace RingCentral
{
    public class RecordingSharingModel
    {
        /// <summary>
        ///     Shared URI of the recording. If a password was required to join a webinar, the URI should contain the password
        ///     encoded
        ///     Required
        ///     Format: uri
        ///     Example: https://v.ringcentral.com/w/a/recording/de7yd8ew7yfsdfjh899843rgj?pw=a1b2c3d4
        /// </summary>
        public string recordingSharedUri { get; set; }
    }
}