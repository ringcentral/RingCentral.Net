using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Brand.ContractedCountry
{
    public class Index
    {
        public string contractedCountryId;
        public Brand.Index parent;
        public RestClient rc;

        public Index(Brand.Index parent, string contractedCountryId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.contractedCountryId = contractedCountryId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && contractedCountryId != null)
                return $"{parent.Path()}/contracted-country/{contractedCountryId}";

            return $"{parent.Path()}/contracted-country";
        }

        /// <summary>
        ///     Returns the list of contracted countries for the given brand.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/brand/{brandId}/contracted-country
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<ContractedCountryListResponse> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<ContractedCountryListResponse>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Returns the list of domestic countries for account contracted country and brand.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/brand/{brandId}/contracted-country/{contractedCountryId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<CountryListDictionaryModel> Get(
            ListDomesticCountriesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (contractedCountryId == null)
                throw new ArgumentException("Parameter cannot be null", nameof(contractedCountryId));

            return await rc.Get<CountryListDictionaryModel>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary.Brand
{
    public partial class Index
    {
        public ContractedCountry.Index ContractedCountry(string contractedCountryId = null)
        {
            return new ContractedCountry.Index(this, contractedCountryId);
        }
    }
}