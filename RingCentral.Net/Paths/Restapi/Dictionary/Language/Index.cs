using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Language
{
    public class Index
    {
        public string languageId;
        public Dictionary.Index parent;
        public RestClient rc;

        public Index(Dictionary.Index parent, string languageId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.languageId = languageId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && languageId != null) return $"{parent.Path()}/language/{languageId}";
            return $"{parent.Path()}/language";
        }

        /// <summary>
        ///     Returns the information about supported languages.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/language
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<LanguageList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<LanguageList>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Returns language by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/language/{languageId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<LanguageInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (languageId == null) throw new ArgumentException("Parameter cannot be null", nameof(languageId));
            return await rc.Get<LanguageInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Language.Index Language(string languageId = null)
        {
            return new Language.Index(this, languageId);
        }
    }
}