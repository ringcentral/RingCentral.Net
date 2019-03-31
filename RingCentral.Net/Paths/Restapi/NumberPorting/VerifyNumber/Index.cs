using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.NumberPorting.VerifyNumber
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.NumberPorting.Index parent;

        public Index(Restapi.NumberPorting.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/verify-number";
        }

        // Operation: Number Porting Verify
        // Http Post /restapi/v1.0/number-porting/verify-number
        public async Task<RingCentral.NumberPortingVerifyNumberResponse> Post(
            RingCentral.NumberPortingVerifyNumberRequest numberPortingVerifyNumberRequest)
        {
            return await rc.Post<RingCentral.NumberPortingVerifyNumberResponse>(this.Path(),
                numberPortingVerifyNumberRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.NumberPorting
{
    public partial class Index
    {
        public Restapi.NumberPorting.VerifyNumber.Index VerifyNumber()
        {
            return new Restapi.NumberPorting.VerifyNumber.Index(this);
        }
    }
}