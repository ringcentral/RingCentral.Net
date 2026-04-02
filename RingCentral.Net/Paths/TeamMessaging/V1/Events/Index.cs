using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Events
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Index parent;
public string eventId;
public Index(TeamMessaging.V1.Index parent, string eventId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.eventId = eventId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && eventId != null)
            {
                return $"{parent.Path()}/events/{eventId}";
            }
            return $"{parent.Path()}/events";
        }
        /// <summary>
        /// Returns all calendar events created by the current user.
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/events
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMEventList> List(RingCentral.ReadGlipEventsNewParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.TMEventList>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates a new calendar event.
        /// HTTP Method: post
        /// Endpoint: /team-messaging/v1/events
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMEventInfo> Post(RingCentral.TMCreateEventRequest tMCreateEventRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.TMEventInfo>(this.Path(false), tMCreateEventRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns the specified calendar event(s) by ID(s).
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMEventInfo> Get(RestRequestConfig restRequestConfig = null)
  {
if (eventId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(eventId));
    }return await rc.Get<RingCentral.TMEventInfo>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates the specified calendar event.
        /// HTTP Method: put
        /// Endpoint: /team-messaging/v1/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMEventInfo> Put(RingCentral.TMCreateEventRequest tMCreateEventRequest, RestRequestConfig restRequestConfig = null)
  {
if (eventId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(eventId));
    }return await rc.Put<RingCentral.TMEventInfo>(this.Path(), tMCreateEventRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes the specified calendar event.
        /// HTTP Method: delete
        /// Endpoint: /team-messaging/v1/events/{eventId}
        /// Rate Limit Group: Medium
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (eventId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(eventId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Events.Index Events(string eventId = null)
        {
            return new TeamMessaging.V1.Events.Index(this, eventId);
        }
    }
}