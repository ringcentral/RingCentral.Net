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

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/features";
        }

        /// <summary>
        ///     Returns a list of supported features and the information on their
        ///     availability for the current extension. Particular feature(s) can
        ///     be checked by providing `featureId` query parameter. Multiple values
        ///     are supported in the format: `?featureId=Feature1&featureId=Feature2`.
        ///     To get only available features in order to decrease response size,
        ///     `availableOnly=true` query param can be specified. If a feature
        ///     is available for the current user, `"available": true` is returned in
        ///     response for the record with the corresponding feature ID. Otherwise,
        ///     the additional attribute `reason` is returned with the appropriate code:
        ///     - `ServicePlanLimitation` -  a feature is not included in account service plan;
        ///     - `AccountLimitation` - a feature is turned off for account;
        ///     - `ExtensionTypeLimitation` - a feature is not applicable for extension type;
        ///     - `ExtensionLimitation` - a feature is not available for extension, e.g., additional license required;
        ///     - `InsufficientPermissions` - required permission is not granted to the current user (not the one, who is specified
        ///     in the URL, but the one who is calling this API);
        ///     - `ConfigurationLimitation` - a feature is turned off for extension, e.g., by account administrator.
        ///     - `PermissionLimitation` - a feature is unavailable due to a specific permission this extension has.
        ///     Also, some features may have additional parameters, e.g. limits, which are returned in `params` attribute as a
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
        public async Task<FeatureList> Get(ReadExtensionFeaturesParameters queryParams = null,
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