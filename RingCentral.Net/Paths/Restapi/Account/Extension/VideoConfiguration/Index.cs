using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.VideoConfiguration
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/video-configuration";
        }

        /// <summary>
        ///     Returns information about video configuration settings of the current user.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/video-configuration
        ///     Rate Limit Group: Light
        ///     App Permission: VideoInternal
        ///     User Permission: Meetings
        /// </summary>
        public async Task<UserVideoConfiguration> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserVideoConfiguration>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Allows to update user video configuration settings, for example video provider.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/video-configuration
        ///     Rate Limit Group: Light
        ///     App Permission: VideoInternal
        /// </summary>
        public async Task<UserVideoConfiguration> Put(UserVideoConfiguration userVideoConfiguration,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<UserVideoConfiguration>(Path(), userVideoConfiguration, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public VideoConfiguration.Index VideoConfiguration()
        {
            return new VideoConfiguration.Index(this);
        }
    }
}