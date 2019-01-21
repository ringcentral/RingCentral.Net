using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ListMeetingRecordingsResponse : Serializable
    {
        public MeetingRecordingInfo[] records;
        public PagingInfo paging;
        public NavigationInfo navigation;
    }
}