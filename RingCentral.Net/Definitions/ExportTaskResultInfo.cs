namespace RingCentral
{
    public class ExportTaskResultInfo
    {
        /// <summary>
        ///     Internal identifier of a dataset
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link for downloading a dataset
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Size of ta dataset in bytes
        ///     Format: int64
        /// </summary>
        public long? size { get; set; }
    }
}