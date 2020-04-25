using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Persons
{
    public partial class Index
    {
        public RestClient rc;
        public string personId;
        public Restapi.Glip.Index parent;

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
        /// Operation: Get Person
        /// Http Get /restapi/v1.0/glip/persons/{personId}
        /// </summary>
        public async Task<RingCentral.GlipPersonInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.personId == null)
            {
                throw new System.ArgumentNullException("personId");
            }

            return await rc.Get<RingCentral.GlipPersonInfo>(this.Path(), null, cancellationToken);
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