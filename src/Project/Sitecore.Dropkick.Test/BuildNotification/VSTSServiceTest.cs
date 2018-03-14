namespace Sitecore.Dropkick.Test.BuildNotification
{
    using global::Dropkick.Feature.VSTSBuildNotification.Models;
    using global::Dropkick.Feature.VSTSBuildNotification.Services;
    using Moq;
    using NUnit.Framework;
    using RestSharp;
    using Sitecore.Dropkick.BuildNotification.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    [TestFixture]
    public class VSTSServiceTest
    {
        private const int BuildDefinitionId = 2;

        [Test]
        public async Task GetBuildsOKTest()
        {
            var builds = new BuildsDTO();
            
            var rr = new RestResponse<BuildsDTO>
            {
                StatusCode = HttpStatusCode.OK,
                Data = builds
            };
           
            var restClient = new Mock<IRestClient>();
            restClient
                .Setup(x => x.ExecuteTaskAsync<BuildsDTO>(
                    It.IsAny<IRestRequest>(),
                    It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(rr as IRestResponse<BuildsDTO>));
            
            var _service = new VSTSService(restClient.Object);
            var b = await _service.GetBuildsAsync(BuildDefinitionId);

            Assert.IsNotNull(b);
        }

        [Test]
        public async Task GetBuildsFailTest()
        {
            var builds = new BuildsDTO();

            var rr = new RestResponse<BuildsDTO>
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Data = null
            };

            var restClient = new Mock<IRestClient>();
            restClient
                .Setup(x => x.ExecuteTaskAsync<BuildsDTO>(
                    It.IsAny<IRestRequest>(),
                    It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(rr as IRestResponse<BuildsDTO>));

            var _service = new VSTSService(restClient.Object);
            var b = await _service.GetBuildsAsync(BuildDefinitionId);

            Assert.IsNull(b);
        }
    }
}
