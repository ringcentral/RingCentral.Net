using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.AdaptiveCards
{
    public class Index
    {
        public string cardId;
        public Glip.Index parent;
        public RestClient rc;

        public Index(Glip.Index parent, string cardId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.cardId = cardId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && cardId != null) return $"{parent.Path()}/adaptive-cards/{cardId}";
            return $"{parent.Path()}/adaptive-cards";
        }

        /// <summary>
        ///     Returns adaptive card(s) with given id(s).
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/glip/adaptive-cards/{cardId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipAdaptiveCardInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null) throw new ArgumentException("Parameter cannot be null", nameof(cardId));
            return await rc.Get<GlipAdaptiveCardInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates an adaptive card.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/glip/adaptive-cards/{cardId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<GlipAdaptiveCardShortInfo> Put(GlipAdaptiveCardRequest glipAdaptiveCardRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null) throw new ArgumentException("Parameter cannot be null", nameof(cardId));
            return await rc.Put<GlipAdaptiveCardShortInfo>(Path(), glipAdaptiveCardRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes an adaptive card by ID.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/glip/adaptive-cards/{cardId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        ///     User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null) throw new ArgumentException("Parameter cannot be null", nameof(cardId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public AdaptiveCards.Index AdaptiveCards(string cardId = null)
        {
            return new AdaptiveCards.Index(this, cardId);
        }
    }
}