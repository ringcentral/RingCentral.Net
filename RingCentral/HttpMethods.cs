using System.Threading.Tasks;

namespace RingCentral.Net
{
    public partial class RingCentral
    {
        public async Task<Response<T>> Request<T>(string method, string path, string body = null, bool basicAuth = false)
        {
            return (await Request(method, path, body, basicAuth)).ConvertTo<T>();
        }

        public Task<Response> Post(string path, Serializable body = null)
        {
            return Request("POST", path, body == null ? null : body.ToJsonString());
        }
        public async Task<Response<T>> Post<T>(string path, Serializable body = null)
        {
            return (await Post(path, body)).ConvertTo<T>();
        }

        public Task<Response> Put(string path, Serializable body = null)
        {
            return Request("PUT", path, body == null ? null : body.ToJsonString());
        }
        public async Task<Response<T>> Put<T>(string path, Serializable body = null)
        {
            return (await Put(path, body)).ConvertTo<T>();
        }

        public Task<Response> Delete(string path)
        {
            return Request("DELETE", path);
        }
        public async Task<Response<T>> Delete<T>(string path)
        {
            return (await Delete(path)).ConvertTo<T>();
        }

        public Task<Response> Get(string path)
        {
            return Request("GET", path);
        }
        public async Task<Response<T>> Get<T>(string path)
        {
            return (await Get(path)).ConvertTo<T>();
        }

        public Task<Response> Patch(string path)
        {
            return Request("PATCH", path);
        }
        public async Task<Response<T>> Patch<T>(string path)
        {
            return (await Patch(path)).ConvertTo<T>();
        }
    }
}