namespace RingCentral
  {
      public class IvrMenuList
      {
          /// <summary>
        ///     Link to an IVR Menu list
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of ivr menus
        /// </summary>
        public IvrMenuListInfo[] records { get; set; }
      }
  }