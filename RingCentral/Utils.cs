using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace RingCentral
{
    public static class Utils
    {
        public static IEnumerable<(string name, object value)> GetPairs(object obj)
        {
            return obj.GetType().GetFields().Select(f => (name: f.Name, value: f.GetValue(obj)))
                .Concat(obj.GetType().GetProperties().Select(p => (name: p.Name, value: p.GetValue(obj))))
                .Where(t => t.value != null);
        }

        public static MultipartFormDataContent GetMultipartFormDataContent(object obj)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            var pairs = Utils.GetPairs(obj);
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
            return multipartFormDataContent;
        }
    }
}