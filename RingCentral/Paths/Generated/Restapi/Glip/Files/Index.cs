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
            var stringContent =
                new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(dict), System.Text.Encoding.UTF8,
                    "application/json");
            multipartFormDataContent.Add(stringContent, "request.json");
            pairs.Where(p => p.value is Attachment || p.value is IEnumerable<Attachment>).ToList().ForEach(p =>
            {
                var attachments = p.value;
                if (!(attachments is IEnumerable<Attachment>))
                {
                    attachments = new[] {attachments};
                }

                (attachments as IEnumerable<Attachment>).ToList().ForEach(attachment =>
                {
                    var content = new ByteArrayContent(attachment.bytes);
                    multipartFormDataContent.Add(content, attachment.fileName, attachment.fileName);
                });
            });
            return await rc.Post<RingCentral.PostGlipFile>(this.Path(), multipartFormDataContent);
        }
    }

    public class PostQueryParams
    {
        // Internal identifier of a group to which the post with attachement will be added to
        public long? groupId;

        // Name of a file attached
        public string name;
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