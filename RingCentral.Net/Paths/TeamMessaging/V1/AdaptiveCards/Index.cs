using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.V1.AdaptiveCards
{
    public class Index
    {
        public string cardId;
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent, string cardId = null)
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
        ///     Endpoint: /team-messaging/v1/adaptive-cards/{cardId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<AdaptiveCardInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null) throw new ArgumentException("Parameter cannot be null", nameof(cardId));
            return await rc.Get<AdaptiveCardInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates an adaptive card.
        ///     HTTP Method: put
        ///     Endpoint: /team-messaging/v1/adaptive-cards/{cardId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<AdaptiveCardShortInfo> Put(AdaptiveCardRequest adaptiveCardRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null) throw new ArgumentException("Parameter cannot be null", nameof(cardId));
            return await rc.Put<AdaptiveCardShortInfo>(Path(), adaptiveCardRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes an adaptive card by ID.
        ///     HTTP Method: delete
        ///     Endpoint: /team-messaging/v1/adaptive-cards/{cardId}
        ///     Rate Limit Group: Medium
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null) throw new ArgumentException("Parameter cannot be null", nameof(cardId));
            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public AdaptiveCards.Index AdaptiveCards(string cardId = null)
        {
            return new AdaptiveCards.Index(this, cardId);
        }
    }
}