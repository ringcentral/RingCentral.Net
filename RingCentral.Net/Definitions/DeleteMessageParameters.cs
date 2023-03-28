namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation deleteMessage
    /// </summary>
    public class DeleteMessageParameters
    {
        /// <summary>
        ///     If the value is `true`, then the message is purged immediately
        ///     with all the attachments
        /// </summary>
        public bool? purge { get; set; }
    }
}