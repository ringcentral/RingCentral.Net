using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.ForwardingNumber
{
    public partial class Index
    {
        public RestClient rc;
        public string forwardingNumberId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string forwardingNumberId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.forwardingNumberId = forwardingNumberId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && forwardingNumberId != null)
            {
                return $"{parent.Path()}/forwarding-number/{forwardingNumberId}";
            }

            return $"{parent.Path()}/forwarding-number";
        }

        /// <summary>
        /// Operation: Get Forwarding Number List
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number
        /// </summary>
        public async Task<RingCentral.GetExtensionForwardingNumberListResponse> List(
            ListForwardingNumbersParameters queryParams = null, CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GetExtensionForwardingNumberListResponse>(this.Path(false), queryParams,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Create Forwarding Number
        /// Rate Limit Group: Medium
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number
        /// </summary>
        public async Task<RingCentral.ForwardingNumberInfo> Post(
            RingCentral.CreateForwardingNumberRequest createForwardingNumberRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.ForwardingNumberInfo>(this.Path(false), createForwardingNumberRequest,
                null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Forwarding Number
        /// Rate Limit Group: Light
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        /// </summary>
        public async Task<RingCentral.ForwardingNumberInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.forwardingNumberId == null)
            {
                throw new System.ArgumentNullException("forwardingNumberId");
            }

            return await rc.Get<RingCentral.ForwardingNumberInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Forwarding Number
        /// Rate Limit Group: Medium
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        /// </summary>
        public async Task<RingCentral.ForwardingNumberInfo> Put(
            RingCentral.UpdateForwardingNumberRequest updateForwardingNumberRequest,
            CancellationToken? cancellationToken = null)
        {
            if (this.forwardingNumberId == null)
            {
                throw new System.ArgumentNullException("forwardingNumberId");
            }

            return await rc.Put<RingCentral.ForwardingNumberInfo>(this.Path(), updateForwardingNumberRequest, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Forwarding Number
        /// Rate Limit Group: Medium
        /// Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.forwardingNumberId == null)
            {
                throw new System.ArgumentNullException("forwardingNumberId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.ForwardingNumber.Index ForwardingNumber(string forwardingNumberId = null)
        {
            return new Restapi.Account.Extension.ForwardingNumber.Index(this, forwardingNumberId);
        }
    }
}