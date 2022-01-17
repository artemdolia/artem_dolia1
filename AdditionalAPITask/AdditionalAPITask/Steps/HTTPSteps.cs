using AdditionalAPITask.Managers;
using RestSharp;
using System.Threading.Tasks;

namespace AdditionalAPITask.Steps
{
    public class HTTPSteps
    {
        public string BaseUrl => LinkConstants.BaseUrl;

        protected RestClient RestClient => new RestClient(this.BaseUrl);

        public async Task<RestResponse> GetAsync(string resource)
        {
            var request = new RestRequest(resource, Method.Get);
            return await this.RestClient.ExecuteAsync<RestResponse>(request, Method.Get);
        }
        public async Task<RestResponse> PostAsync(string resource)
        {
            var request = new RestRequest(resource, Method.Post);
            return await this.RestClient.ExecuteAsync<RestResponse>(request, Method.Post);
        }
        public async Task<RestResponse> DeleteAsync(string resource)
        {
            var request = new RestRequest(resource, Method.Delete);
            return await this.RestClient.ExecuteAsync<RestResponse>(request, Method.Delete);
        }
        public async Task<RestResponse> PutAsync(string resource)
        {
            var request = new RestRequest(resource, Method.Put);
            return await this.RestClient.ExecuteAsync<RestResponse>(request, Method.Put);
        }

    }
}

