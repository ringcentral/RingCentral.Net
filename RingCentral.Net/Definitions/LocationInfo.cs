namespace RingCentral
{
    public class LocationInfo
    {
        /// <summary>
        /// Canonical URI of a location
        /// </summary>
        public string uri;

        /// <summary>
        /// Area code of the location
        /// </summary>
        public string areaCode;

        /// <summary>
        /// Official name of the city, belonging to the certain state
        /// </summary>
        public string city;

        /// <summary>
        /// Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
        /// </summary>
        public string npa;

        /// <summary>
        /// Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
        /// </summary>
        public string nxx;

        /// <summary>
        /// </summary>
        public LocationStateInfo state;
    }
}