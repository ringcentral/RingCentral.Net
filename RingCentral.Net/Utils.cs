using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace RingCentral
{
    public static class Utils
    {
        public static IEnumerable<(string name, object value)> GetPairs(params object[] objs)
        {
            return objs.Select(obj => obj.GetType().GetFields().Select(f => (name: f.Name, value: f.GetValue(obj)))
                .Concat(obj.GetType().GetProperties().Select(p => (name: p.Name, value: p.GetValue(obj))))
                .Where(t => t.value != null)).SelectMany(p => p);
        }

        public static MultipartFormDataContent GetMultipartFormDataContent(params object[] objs)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            var pairs = GetPairs(objs);
            var dict = pairs.Where(p => !(p.value is Attachment || p.value is IEnumerable<Attachment>))
                .ToDictionary(p => p.name, p => p.value);
            if (dict.Count > 0)
            {
                var stringContent =
                    new StringContent(JsonConvert.SerializeObject(dict), Encoding.UTF8,
                        "application/json");
                multipartFormDataContent.Add(stringContent, "request.json");
            }

            pairs.Where(p => p.value is Attachment || p.value is IEnumerable<Attachment>).ToList().ForEach(p =>
            {
                var attachments = p.value;
                if (!(attachments is IEnumerable<Attachment>)) attachments = new[] {attachments};

                ((object[]) attachments).Select(a => a as Attachment).ToList().ForEach(attachment =>
                {
                    var content = new ByteArrayContent(attachment.content);
                    if (attachment.contentType != null)
                        content.Headers.ContentType =
                            new MediaTypeHeaderValue(attachment.contentType);

                    multipartFormDataContent.Add(content, p.name, attachment.filename);
                });
            });
            return multipartFormDataContent;
        }

        public static string FormatHttpMessage(HttpResponseMessage httpResponseMessage,
            HttpRequestMessage httpRequestMessage)
        {
            var message = $"Response:\n{httpResponseMessage}";
            if (httpResponseMessage.Content != null)
                message += $"\nContent: {httpResponseMessage.Content.ReadAsStringAsync().Result}";

            message += $"\n\nRequest:\n{httpRequestMessage}";
            if (httpRequestMessage.Content != null)
                try
                {
                    message += $"\nContent: {httpRequestMessage.Content.ReadAsStringAsync().Result}";
                }
                catch (ObjectDisposedException)
                {
                    message +=
                        "\nContent: <content has been disposed by HttpClient: https://github.com/dotnet/corefx/issues/1794>";
                }

            return message;
        }
    }
}