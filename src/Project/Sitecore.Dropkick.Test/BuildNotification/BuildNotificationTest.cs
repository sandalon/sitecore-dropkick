namespace Sitecore.Dropkick.Test.BuildNotification
{
    using global::Dropkick.Feature.VSTSBuildNotification.Services;
    using NUnit.Framework;
    using Sitecore.Dropkick.BuildNotification.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class BuildNotificationTest
    {
        [Test]
        public void BuildCompletedTest()
        {
            var _service = new VSTSBuildNotificationService();

            var didBuildComplete = false;
            _service.OnBuildCompleted += (o, e) => {
                didBuildComplete = true;
            };

            Assert.IsTrue(didBuildComplete);
        }
    }
}
