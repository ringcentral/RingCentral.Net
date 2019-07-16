using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.WirelessPoints
{
    public partial class Index
    {
        public RestClient rc;
        public string pointId;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent, string pointId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.pointId = pointId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && pointId != null)
            {
                return $"{parent.Path()}/wireless-points/{pointId}";
            }

            return $"{parent.Path()}/wireless-points";
        }

        /// <summary>
        /// Operation: Get Wireless Point List
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points
        /// </summary>
        public async Task<RingCentral.WirelessPointsList> List(ListWirelessPointsParameters queryParams = null)
        {
            return await rc.Get<RingCentral.WirelessPointsList>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Create Wireless Point
        /// Http Post /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points
        /// </summary>
        public async Task<RingCentral.WirelessPointInfo> Post(RingCentral.CreateWirelessPoint createWirelessPoint)
        {
            return await rc.Post<RingCentral.WirelessPointInfo>(this.Path(false), createWirelessPoint);
        }

        /// <summary>
        /// Operation: Get Wireless Point
        /// Http Get /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// </summary>
        public async Task<RingCentral.WirelessPointInfo> Get()
        {
            if (this.pointId == null)
            {
                throw new System.ArgumentNullException("pointId");
            }

            return await rc.Get<RingCentral.WirelessPointInfo>(this.Path());
        }

        /// <summary>
        /// Operation: Update Wireless Point
        /// Http Put /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// </summary>
        public async Task<RingCentral.WirelessPointInfo> Put(RingCentral.UpdateWirelessPoint updateWirelessPoint)
        {
            if (this.pointId == null)
            {
                throw new System.ArgumentNullException("pointId");
            }

            return await rc.Put<RingCentral.WirelessPointInfo>(this.Path(), updateWirelessPoint);
        }

        /// <summary>
        /// Operation: Delete Wireless Point
        /// Http Delete /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.pointId == null)
            {
                throw new System.ArgumentNullException("pointId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.WirelessPoints.Index WirelessPoints(string pointId = null)
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.WirelessPoints.Index(this, pointId);
        }
    }
}