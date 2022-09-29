namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by actions
    /// </summary>
    public class CallsByActionsBreakdown
    {
        /// <summary>
        ///     Value for ParkOn action
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? parkOn { get; set; }

        /// <summary>
        ///     Value for ParkOff action
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? parkOff { get; set; }

        /// <summary>
        ///     Value for HoldOn action
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? holdOn { get; set; }

        /// <summary>
        ///     Value for HoldOff action
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? holdOff { get; set; }

        /// <summary>
        ///     Value for BlindTransfer action
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? blindTransfer { get; set; }

        /// <summary>
        ///     Value for WarmTransfer action
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? warmTransfer { get; set; }

        /// <summary>
        ///     Value for DTMFTransfer action
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? dtmfTransfer { get; set; }
    }
}