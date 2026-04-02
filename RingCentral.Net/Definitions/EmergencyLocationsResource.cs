namespace RingCentral
  {
      public class EmergencyLocationsResource
      {
          /// <summary>
        ///     Link to an emergency locations resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public CommonEmergencyLocationResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public EmergencyLocationsPaging paging { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }
      }
  }