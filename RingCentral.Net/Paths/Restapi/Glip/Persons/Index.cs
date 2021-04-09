using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Persons
{
    public class Index
    {
        public Glip.Index parent;
        public string personId;
        public RestClient rc;

        public Index(Glip.Index parent, string personId = null)
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
        ///     Endpoint: /restapi/{apiVersion}/glip/persons/{personId}
        ///     Rate Limit Group: Light
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<GlipPersonInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GlipPersonInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Persons.Index Persons(string personId = null)
        {
            return new Persons.Index(this, personId);
        }
    }
}