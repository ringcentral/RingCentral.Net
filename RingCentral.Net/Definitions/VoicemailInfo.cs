namespace RingCentral
{
    public class VoicemailInfo
    {
        /// <summary>
        /// If 'True' then voicemails are allowed to be received
        /// </summary>
        public bool? enabled;

        /// <summary>
        /// Recipient data
        /// </summary>
        public RecipientInfo recipient;
    }
}