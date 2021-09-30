using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Features
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
            return $"{parent.Path()}/features";
        }

        /// <summary>
        ///     Returns the list of supported features and information on their availability for the current extension. Specific
        ///     feature(s) might be checked by providing `featureId` query param. Multiple values supported, format:
        ///     `?featureId=Feature1&featureId=Feature2`. To get only available features in order to decrease response size,
        ///     `availableOnly=true` query param might be specified.
        ///     In case the feature is available for the current user, `"available": true` is returned in the response for the
        ///     record with corresponding feature `id`. Otherwise, additional attribute `reason` is returned with the appropriate
        ///     code:
        ///     * `ServicePlanLimitation` - the feature not included to the account service plan;
        ///     * `AccountLimitation` - the feature is turned off for the account;
        ///     * `ExtensionTypeLimitation` - the feature is not applicable for the extension type;
        ///     * `ExtensionLimitation` - the feature is not available for the extension, e.g., additional license required;
        ///     * `InsufficientPermissions` - required permission not granted to the current user (not the one, who is specified in
        ///     the URL, but the one who's access token is used);
        ///     * `ConfigurationLimitation` - the feature is turned off for the extension, e.g., by the account administrator.
        ///     Also, some feature may have some additional parameters, e.g., limits, which are returned in `params` attribute as a
        ///     name-value collection:
        ///     {
        ///     "id": "HUD",
        ///     "available": true,
        ///     "params": [
        ///     {
        ///     "name": "limitMax",
        ///     "value": "100"
        ///     }
        ///     ]
        ///     }
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/features
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<FeatureList> Get(ReadUserFeaturesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<FeatureList>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Features.Index Features()
        {
            return new Features.Index(this);
        }
    }
}