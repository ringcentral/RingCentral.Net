using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Files
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/files";
        }

        public async Task<RingCentral.PostGlipFile> Post(CreateGlipFileRequest createGlipFileRequest)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            var pairs = Utils.GetPairs(createGlipFileRequest);
            var dict = pairs.Where(p => !(p.value is Attachment || p.value is IEnumerable<Attachment>))
                .ToDictionary(p => p.name, p => p.value);
            if (dict.Count > 0)
            {
                var stringContent =
                    new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(dict), System.Text.Encoding.UTF8,
                        "application/json");
                multipartFormDataContent.Add(stringContent, "request.json");
            }

            pairs.Where(p => p.value is Attachment || p.value is IEnumerable<Attachment>).ToList().ForEach(p =>
            {
                var attachments = p.value;
                if (!(attachments is IEnumerable<Attachment>))
                {
                    attachments = new[] {attachments};
                }

                ((object[]) attachments).Select(a => a as Attachment).ToList().ForEach(attachment =>
                {
                    var content = new ByteArrayContent(attachment.bytes);
                    if (attachment.contentType != null)
                    {
                        content.Headers.ContentType =
                            new System.Net.Http.Headers.MediaTypeHeaderValue(attachment.contentType);
                    }

                    multipartFormDataContent.Add(content, p.name, attachment.fileName);
                });
            });
            return await rc.Post<RingCentral.PostGlipFile>(this.Path(), multipartFormDataContent);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Files.Index Files()
        {
            return new Restapi.Glip.Files.Index(this);
        }
    }
}