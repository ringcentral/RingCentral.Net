namespace RingCentral
  {
      public class TcrBrandRecord
      {
          /// <summary>
        ///     Identifier of a TCR brand
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Name of a TCR brand
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Country code
        /// </summary>
        public string countryCode { get; set; }

        /// <summary>
        ///     Enum: Created, Submitted, SubmitFailed, Verified, Unverified, UpdateRequested, DeleteRequested, Suspended, Expired, Draft, PreventFailed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Registration time
        ///     Format: date-time
        /// </summary>
        public string registrationTime { get; set; }

        /// <summary>
        ///     External ID
        /// </summary>
        public string externalId { get; set; }

        /// <summary>
        /// </summary>
        public CompanyDetails companyDetails { get; set; }

        /// <summary>
        /// </summary>
        public ApiErrorWithParameter[] errors { get; set; }
      }
  }