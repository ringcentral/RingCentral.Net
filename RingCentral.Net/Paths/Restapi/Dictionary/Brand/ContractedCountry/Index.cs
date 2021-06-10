using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.Brand.ContractedCountry
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Brand.Index parent;
        public string contractedCountryId;

        public Index(Restapi.Dictionary.Brand.Index parent, string contractedCountryId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.contractedCountryId = contractedCountryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && contractedCountryId != null)
            {
                return $"{parent.Path()}/contracted-country/{contractedCountryId}";
            }

            return $"{parent.Path()}/contracted-country";
        }

        /// <summary>
        /// Returns the list of domestic countries by contracted country and brand of the account.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/brand/{brandId}/contracted-country/{contractedCountryId}
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.GetCountryListResponse> Get(
            RingCentral.ListDomesticCountriesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (contractedCountryId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(contractedCountryId));
            }

            return await rc.Get<RingCentral.GetCountryListResponse>(this.Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary.Brand
{
    public partial class Index
    {
        public Restapi.Dictionary.Brand.ContractedCountry.Index ContractedCountry(string contractedCountryId = null)
        {
            return new Restapi.Dictionary.Brand.ContractedCountry.Index(this, contractedCountryId);
        }
    }
}