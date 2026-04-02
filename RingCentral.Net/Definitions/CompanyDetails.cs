namespace RingCentral
  {
      public class CompanyDetails
      {
          /// <summary>
        ///     Business contact email
        ///     Format: email
        /// </summary>
        public string businessContactEmail { get; set; }

        /// <summary>
        ///     Company name
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        ///     Industry category
        /// </summary>
        public string industryCategory { get; set; }

        /// <summary>
        ///     Web site URL
        ///     Format: uri
        /// </summary>
        public string webSiteUri { get; set; }

        /// <summary>
        ///     Enum: SoleProprietor, PrivateProfit, PublicProfit, NonProfit, Government
        /// </summary>
        public string commercialType { get; set; }

        /// <summary>
        /// </summary>
        public BusinessAddress businessAddress { get; set; }

        /// <summary>
        /// </summary>
        public Contact contact { get; set; }
      }
  }