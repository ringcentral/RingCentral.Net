namespace RingCentral
{
    public class EditPagingGroupRequest
    {
        /// <summary>
        ///     List of users that will be allowed to page a group specified
        /// </summary>
        public string[] addedUserIds { get; set; }

        /// <summary>
        ///     List of users that will be disallowed to page a group specified
        /// </summary>
        public string[] removedUserIds { get; set; }

        /// <summary>
        ///     List of account devices that will be assigned to a paging group
        ///     specified
        /// </summary>
        public string[] addedDeviceIds { get; set; }

        /// <summary>
        ///     List of account devices that will be unassigned from a paging
        ///     group specified
        /// </summary>
        public string[] removedDeviceIds { get; set; }
    }
}