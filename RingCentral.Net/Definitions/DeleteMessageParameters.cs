namespace RingCentral
{
    public class DeleteMessageParameters
    {
        /* If the value is 'True', then the message is purged immediately with all the attachments */
        public bool? purge;

        /* Internal identifier of a message thread */
        public long? conversationId;
    }
}