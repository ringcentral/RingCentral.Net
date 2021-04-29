using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.Language
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;
        public string languageId;

        public Index(Restapi.Dictionary.Index parent, string languageId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.languageId = languageId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && languageId != null)
            {
                return $"{parent.Path()}/language/{languageId}";
            }

            return $"{parent.Path()}/language";
        }

        /// <summary>
        /// Returns the information about supported languages.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/language
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.LanguageList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.LanguageList>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Returns language by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/language/{languageId}
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.LanguageInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.LanguageInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.Language.Index Language(string languageId = null)
        {
            return new Restapi.Dictionary.Language.Index(this, languageId);
        }
    }
}