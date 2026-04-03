using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.AdaptiveCards
{
    public partial class Index
    {
        public RestClient rc;
        public TeamMessaging.V1.Index parent;
        public string cardId;
        public Index(TeamMessaging.V1.Index parent, string cardId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.cardId = cardId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && cardId != null)
            {
                return $"{parent.Path()}/adaptive-cards/{cardId}";
            }
            return $"{parent.Path()}/adaptive-cards";
        }
        /// <summary>
        /// Returns adaptive card(s) with given id(s).
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/adaptive-cards/{cardId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.AdaptiveCardInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(cardId));
            }
            return await rc.Get<RingCentral.AdaptiveCardInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates an adaptive card.
        /// HTTP Method: put
        /// Endpoint: /team-messaging/v1/adaptive-cards/{cardId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<RingCentral.AdaptiveCardShortInfo> Put(RingCentral.AdaptiveCardRequest adaptiveCardRequest, RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(cardId));
            }
            return await rc.Put<RingCentral.AdaptiveCardShortInfo>(this.Path(), adaptiveCardRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes an adaptive card by ID.
        /// HTTP Method: delete
        /// Endpoint: /team-messaging/v1/adaptive-cards/{cardId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (cardId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(cardId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.AdaptiveCards.Index AdaptiveCards(string cardId = null)
        {
            return new TeamMessaging.V1.AdaptiveCards.Index(this, cardId);
        }
    }
}