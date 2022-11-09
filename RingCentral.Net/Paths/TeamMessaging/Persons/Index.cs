using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.TeamMessaging.Persons
{
    public class Index
    {
        public TeamMessaging.Index parent;
        public string personId;
        public RestClient rc;

        public Index(TeamMessaging.Index parent, string personId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.personId = personId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && personId != null) return $"{parent.Path()}/persons/{personId}";
            return $"{parent.Path()}/persons";
        }

        /// <summary>
        ///     Returns a user or multiple users by their ID(s). Batch request is supported.
        ///     HTTP Method: get
        ///     Endpoint: /team-messaging/{version}/persons/{personId}
        ///     Rate Limit Group: Light
        ///     App Permission: TeamMessaging
        /// </summary>
        public async Task<TMPersonInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (personId == null) throw new ArgumentException("Parameter cannot be null", nameof(personId));
            return await rc.Get<TMPersonInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.TeamMessaging
{
    public partial class Index
    {
        public Persons.Index Persons(string personId = null)
        {
            return new Persons.Index(this, personId);
        }
    }
}