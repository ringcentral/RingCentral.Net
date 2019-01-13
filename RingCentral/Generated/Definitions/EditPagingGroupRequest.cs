using Newtonsoft.Json;

namespace RingCentral
{
    public class EditPagingGroupRequest : Serializable
    {
        // List of users that will be allowed to page a group specified
        public string[] addedUserIds;
        // List of users that will be unallowed to page a group specified
        public string[] removedUserIds;
        // List of account devices that will be assigned to a paging group specified
        public string[] addedDeviceIds;
        // List of account devices that will be unassigned from a paging group specified
        public string[] removedDeviceIds;
    }
}