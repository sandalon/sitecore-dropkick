namespace Dropkick.Feature.VSTSBuildNotification.Services
{
    using Sitecore.Dropkick.BuildNotification.Events;
    using Sitecore.Dropkick.BuildNotification.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VSTSBuildNotificationService : IBuildNotificationService
    {

        private EventHandler<OnBuildCompletedEventArgs> _buildCompleted;
        public EventHandler<OnBuildCompletedEventArgs> OnBuildCompleted
        {
            get { return _buildCompleted; }
            set { _buildCompleted = value; }
        }

        public bool IsNewBuildAvailable()
        {
            throw new NotImplementedException();
        }
    }
}
