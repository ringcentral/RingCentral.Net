namespace RingCentral
{
    // Specifies whether to take a voicemail and who should do it
    public class VoicemailInfo
    {
        /// <summary>
        ///     If 'True' then voicemails are allowed to be received
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        /// </summary>
        public RecipientInfo recipient { get; set; }
    }
}