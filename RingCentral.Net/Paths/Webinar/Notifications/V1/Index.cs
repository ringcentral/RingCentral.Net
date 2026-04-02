using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Webinar.Notifications.V1
{
    public partial class Index
    {
        public RestClient rc;
public Webinar.Notifications.Index parent;
public Index(Webinar.Notifications.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path(false)}/v1";
        }

    }
}

namespace RingCentral.Paths.Webinar.Notifications
{
    public partial class Index
    {
        public Webinar.Notifications.V1.Index V1()
        {
            return new Webinar.Notifications.V1.Index(this);
        }
    }
}