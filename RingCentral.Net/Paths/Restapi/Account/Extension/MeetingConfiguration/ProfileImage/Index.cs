using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingConfiguration.ProfileImage
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.MeetingConfiguration.Index parent;

        public Index(Restapi.Account.Extension.MeetingConfiguration.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/profile-image";
        }

        /// <summary>
        /// Uploads profile picture for user meetings.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting-configuration/profile-image
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<string> Post(
            RingCentral.CreateUserMeetingProfileImageRequest createUserMeetingProfileImageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createUserMeetingProfileImageRequest);
            return await rc.Post<string>(this.Path(), multipartFormDataContent, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingConfiguration
{
    public partial class Index
    {
        public Restapi.Account.Extension.MeetingConfiguration.ProfileImage.Index ProfileImage()
        {
            return new Restapi.Account.Extension.MeetingConfiguration.ProfileImage.Index(this);
        }
    }
}