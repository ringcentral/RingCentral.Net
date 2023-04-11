namespace RingCentral
{
    public class BulkUpdateInviteesResponse
    {
        /// <summary>
        /// </summary>
        public InviteeResource[] addedInvitees { get; set; }

        /// <summary>
        /// </summary>
        public InviteeResource[] updatedInvitees { get; set; }

        /// <summary>
        /// </summary>
        public RcwResourceIdModel[] deletedInvitees { get; set; }
    }
}