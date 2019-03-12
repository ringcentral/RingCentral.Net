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

        // Operation: Get Language List
        // Http Get /restapi/v1.0/dictionary/language
        public async Task<RingCentral.LanguageList> List()
        {
            return await rc.Get<RingCentral.LanguageList>(this.Path(false));
        }

        // Operation: Get Language
        // Http Get /restapi/v1.0/dictionary/language/{languageId}
        public async Task<RingCentral.LanguageInfo> Get()
        {
            if (this.languageId == null)
            {
                throw new System.ArgumentNullException("languageId");
            }

            return await rc.Get<RingCentral.LanguageInfo>(this.Path());
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