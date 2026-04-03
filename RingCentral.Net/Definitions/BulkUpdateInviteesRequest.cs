namespace RingCentral
{
    public class BulkUpdateInviteesRequest
    {
        /// <summary>
        /// </summary>
        public AddInviteeRequest[] addedInvitees { get; set; }

        /// <summary>
        /// </summary>
        public BulkUpdateInviteesRequestUpdatedInvitees[] updatedInvitees { get; set; }

        /// <summary>
        /// </summary>
        public RcwResourceIdModel[] deletedInvitees { get; set; }
    }
}