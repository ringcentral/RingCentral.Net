using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Glip.Persons
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;
        public string personId;

        public Index(Restapi.Glip.Index parent, string personId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.personId = personId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && personId != null)
            {
                return $"{parent.Path()}/persons/{personId}";
            }

            return $"{parent.Path()}/persons";
        }

        /// <summary>
        /// Returns a user or multiple users by their ID(s). Batch request is supported.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/glip/persons/{personId}
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// User Permission: UnifiedAppDesktop
        /// </summary>
        public async Task<RingCentral.GlipPersonInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (personId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(personId));
            }

            return await rc.Get<RingCentral.GlipPersonInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Persons.Index Persons(string personId = null)
        {
            return new Restapi.Glip.Persons.Index(this, personId);
        }
    }
}