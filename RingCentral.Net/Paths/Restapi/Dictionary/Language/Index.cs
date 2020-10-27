using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Language
{
    public partial class Index
    {
        public RestClient rc;
        public string languageId;
        public Restapi.Dictionary.Index parent;

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
        /// Operation: Get Language List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/language
        /// Rate Limit Group: Light
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.LanguageList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.LanguageList>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Language
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/language/{languageId}
        /// Rate Limit Group: Light
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.LanguageInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.languageId == null)
            {
                throw new System.ArgumentNullException("languageId");
            }

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