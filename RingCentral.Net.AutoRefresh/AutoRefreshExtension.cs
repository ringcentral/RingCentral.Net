using System.Threading.Tasks;
using System.Timers;

namespace RingCentral.Net.AutoRefresh
{
    public class AutoRefreshExtension : SdkExtension
    {
        private readonly AutoRefreshOptions _options;
        private Timer _autoRefreshTimer;
        private RestClient _rc;

        public AutoRefreshExtension(AutoRefreshOptions autoRefreshOptions = null)
        {
            _options = autoRefreshOptions ?? AutoRefreshOptions.DefaultInstance;
        }

        public override Task Install(RestClient rc)
        {
            _rc = rc;
            return Task.CompletedTask;
        }

        public void Start()
        {
            Stop(); // stop existing
            _autoRefreshTimer = new Timer();
            _autoRefreshTimer.Elapsed += (sender, args) => { _rc.Refresh(); };
            _autoRefreshTimer.Interval = _options.interval;
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