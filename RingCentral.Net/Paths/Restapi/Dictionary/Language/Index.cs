using System.Threading.Tasks;
using System.Threading;

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
        /// Http Get /restapi/v1.0/dictionary/language
        /// </summary>
        public async Task<RingCentral.LanguageList> List(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.LanguageList>(this.Path(false), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Language
        /// Http Get /restapi/v1.0/dictionary/language/{languageId}
        /// </summary>
        public async Task<RingCentral.LanguageInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.languageId == null)
            {
                throw new System.ArgumentNullException("languageId");
            }

            return await rc.Get<RingCentral.LanguageInfo>(this.Path(), null, cancellationToken);
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