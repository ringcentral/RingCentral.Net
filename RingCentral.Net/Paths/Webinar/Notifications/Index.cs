using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Notifications
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.Index parent;
public Index(Webinar.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/notifications";
        }

    }
}

namespace RingCentral.Paths.Webinar
{
    public partial class Index
    {
        public Webinar.Notifications.Index Notifications()
        {
            return new Webinar.Notifications.Index(this);
        }
    }
}