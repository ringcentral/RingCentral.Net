using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Status.V1.Jobs
{
    public class Index
    {
        public string jobId;
        public V1.Index parent;
        public RestClient rc;

        public Index(V1.Index parent, string jobId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.jobId = jobId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && jobId != null) return $"{parent.Path()}/jobs/{jobId}";
            return $"{parent.Path()}/jobs";
        }

        /// <summary>
        ///     Returns async task status by Job ID
        ///     HTTP Method: get
        ///     Endpoint: /ai/status/v1/jobs/{jobId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<JobStatusResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (jobId == null) throw new ArgumentException("Parameter cannot be null", nameof(jobId));
            return await rc.Get<JobStatusResponse>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Status.V1
{
    public partial class Index
    {
        public Jobs.Index Jobs(string jobId = null)
        {
            return new Jobs.Index(this, jobId);
        }
    }
}