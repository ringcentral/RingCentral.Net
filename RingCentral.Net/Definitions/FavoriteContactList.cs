namespace RingCentral
{
    public class FavoriteContactList
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public FavoriteContactResource[] records { get; set; }
    }
}