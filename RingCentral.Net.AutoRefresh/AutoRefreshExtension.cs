namespace RingCentral.Net.AutoRefresh
{
    public class AutoRefreshExtension  : SdkExtension
    {
        private RestClient _rc;
        private System.Timers.Timer _autoRefreshTimer = null;
        
        public override void Install(RestClient rc)
        {
            this._rc = rc;
        }

        public void Start(double interval = 1000 * 60 * 30)
        {
            _autoRefreshTimer = new System.Timers.Timer();
            _autoRefreshTimer.Elapsed += (sender, args) => { this._rc.Refresh(); };
            _autoRefreshTimer.Interval = interval;
            _autoRefreshTimer.Start();
        }

        public void Stop()
        {
            if (_autoRefreshTimer != null)
            {
                _autoRefreshTimer.Stop();
                _autoRefreshTimer.Dispose();
                _autoRefreshTimer = null;
            }
        }
    }
}