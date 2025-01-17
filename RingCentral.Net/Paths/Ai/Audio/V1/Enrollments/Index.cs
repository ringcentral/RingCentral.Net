using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Ai.Audio.V1.Enrollments
{
    public class Index
    {
        public V1.Index parent;
        public RestClient rc;
        public string speakerId;

        public Index(V1.Index parent, string speakerId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.speakerId = speakerId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && speakerId != null) return $"{parent.Path()}/enrollments/{speakerId}";

            return $"{parent.Path()}/enrollments";
        }

        /// <summary>
        ///     Returns the List of Enrolled Speakers
        ///     HTTP Method: get
        ///     Endpoint: /ai/audio/v1/enrollments
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<ListEnrolledSpeakers> List(
            CaiEnrollmentsListParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ListEnrolledSpeakers>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates Enrollment for the provided Speaker.
        ///     HTTP Method: post
        ///     Endpoint: /ai/audio/v1/enrollments
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<EnrollmentStatus> Post(EnrollmentInput enrollmentInput,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<EnrollmentStatus>(Path(false), enrollmentInput, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Get The Status of Enrollment for the provided Speaker.
        ///     HTTP Method: get
        ///     Endpoint: /ai/audio/v1/enrollments/{speakerId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<EnrollmentStatus> Get(RestRequestConfig restRequestConfig = null)
        {
            if (speakerId == null) throw new ArgumentException("Parameter cannot be null", nameof(speakerId));

            return await rc.Get<EnrollmentStatus>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Delete The Enrollment for the provided Speaker.
        ///     HTTP Method: delete
        ///     Endpoint: /ai/audio/v1/enrollments/{speakerId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (speakerId == null) throw new ArgumentException("Parameter cannot be null", nameof(speakerId));

            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }

        /// <summary>
        ///     Add newer audio data to improve an existing speaker enrollment
        ///     HTTP Method: patch
        ///     Endpoint: /ai/audio/v1/enrollments/{speakerId}
        ///     Rate Limit Group: Heavy
        ///     App Permission: AI
        /// </summary>
        public async Task<EnrollmentStatus> Patch(EnrollmentPatchInput enrollmentPatchInput,
            RestRequestConfig restRequestConfig = null)
        {
            if (speakerId == null) throw new ArgumentException("Parameter cannot be null", nameof(speakerId));

            return await rc.Patch<EnrollmentStatus>(Path(), enrollmentPatchInput, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Ai.Audio.V1
{
    public partial class Index
    {
        public Enrollments.Index Enrollments(string speakerId = null)
        {
            return new Enrollments.Index(this, speakerId);
        }
    }
}