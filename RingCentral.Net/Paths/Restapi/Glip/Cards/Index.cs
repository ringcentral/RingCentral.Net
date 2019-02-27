using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Cards
{
    public partial class Index
    {
        public RestClient rc;
        public string cardId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string cardId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.cardId = cardId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && cardId != null)
            {
                return $"{parent.Path()}/cards/{cardId}";
            }

            return $"{parent.Path()}/cards";
        }

        // Operation: createGlipCard
        // Http Post /restapi/v1.0/glip/cards
        public async Task<RingCentral.GlipMessageAttachmentInfo> Post(
            RingCentral.GlipMessageAttachmentInfoRequest glipMessageAttachmentInfoRequest,
            CreateGlipCardParameters queryParams = null)
        {
            return await rc.Post<RingCentral.GlipMessageAttachmentInfo>(this.Path(false),
                glipMessageAttachmentInfoRequest, queryParams);
        }

        // Operation: loadGlipCard
        // Http Get /restapi/v1.0/glip/cards/{cardId}
        public async Task<RingCentral.GlipMessageAttachmentInfo> Get()
        {
            if (this.cardId == null)
            {
                throw new System.ArgumentNullException("cardId");
            }

            return await rc.Get<RingCentral.GlipMessageAttachmentInfo>(this.Path());
        }

        // Operation: updateGlipCard
        // Http Put /restapi/v1.0/glip/cards/{cardId}
        public async Task<string> Put(RingCentral.GlipMessageAttachmentInfoRequest glipMessageAttachmentInfoRequest)
        {
            if (this.cardId == null)
            {
                throw new System.ArgumentNullException("cardId");
            }

            return await rc.Put<string>(this.Path(), glipMessageAttachmentInfoRequest);
        }

        // Operation: deleteGlipCard
        // Http Delete /restapi/v1.0/glip/cards/{cardId}
        public async Task<string> Delete()
        {
            if (this.cardId == null)
            {
                throw new System.ArgumentNullException("cardId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Cards.Index Cards(string cardId = null)
        {
            return new Restapi.Glip.Cards.Index(this, cardId);
        }
    }
}