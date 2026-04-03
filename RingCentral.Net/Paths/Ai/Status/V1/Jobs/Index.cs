using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Ai.Status.V1.Jobs
{
    public partial class Index
    {
        public RestClient rc;
        public Ai.Status.V1.Index parent;
        public string jobId;
        public Index(Ai.Status.V1.Index parent, string jobId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.jobId = jobId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && jobId != null)
            {
                return $"{parent.Path()}/jobs/{jobId}";
            }
            return $"{parent.Path()}/jobs";
        }
        /// <summary>
        /// Returns async task status by Job ID
        /// HTTP Method: get
        /// Endpoint: /ai/status/v1/jobs/{jobId}
        /// Rate Limit Group: Heavy
        /// App Permission: AI
        /// </summary>
        public async Task<RingCentral.JobStatusResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (jobId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(jobId));
            }
            return await rc.Get<RingCentral.JobStatusResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Status.V1
{
    public partial class Index
    {
        public Ai.Status.V1.Jobs.Index Jobs(string jobId = null)
        {
            return new Ai.Status.V1.Jobs.Index(this, jobId);
        }
    }
}