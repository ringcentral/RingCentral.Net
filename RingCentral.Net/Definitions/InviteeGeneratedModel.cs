namespace RingCentral
{
    public class InviteeGeneratedModel
    {
        /// <summary>
        ///     Personalized join link for the Invitee
        ///     Format: uri
        ///     Example: https://v.ringcentral.com/w/join/de7yd8ew7yfsdfjh899843rgj
        /// </summary>
        public string joinUri { get; set; }

        /// <summary>
        ///     Phone (PSTN) participant code
        /// </summary>
        public string phoneParticipantCode { get; set; }
    }
}