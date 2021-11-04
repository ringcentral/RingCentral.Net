using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingConfiguration.ProfileImage
{
    public class Index
    {
        public MeetingConfiguration.Index parent;
        public RestClient rc;

        public Index(MeetingConfiguration.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/profile-image";
        }

        /// <summary>
        ///     Uploads profile picture for user meetings.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meeting-configuration/profile-image
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<string> Post(
            CreateUserMeetingProfileImageRequest createUserMeetingProfileImageRequest,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createUserMeetingProfileImageRequest);
            return await rc.Post<string>(Path(), multipartFormDataContent, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingConfiguration
{
    public partial class Index
    {
        public ProfileImage.Index ProfileImage()
        {
            return new ProfileImage.Index(this);
        }
    }
}