namespace Dropkick.Feature.VSTSBuildNotification.Services
{
    using Dropkick.Feature.VSTSBuildNotification.Models;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class VSTSService : IVSTSService
    {
        private IRestClient _restClient;

        public VSTSService(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<BuildsDTO> GetBuildsAsync(int buildDefinitionId)
        {
            var rr = new RestRequest
            {
                Method = Method.GET,
                Resource = "https://baycare-ese.visualstudio.com/Applications/_apis/build/builds?definitions=2&api-version=4.1-preview"
            };
            rr.AddHeader("Authorization", "Basic Y29yZXkubWNjbGVsbGFuZEBiYXljYXJlLm9yZzp0ZmkzZW5pNmd4M2tzdHU2cG9qdW5hdWQzaW10bnFjZmduNWRsaTM3ZzM3amV0am4yeGFx");
            var ct = new CancellationToken();
            var response = await _restClient.ExecuteTaskAsync<BuildsDTO>(rr, ct);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                return null;

            return response.Data;
        }
    }
}
