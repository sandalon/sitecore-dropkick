namespace Sitecore.Dropkick.BuildNotification.Services
{
    using Sitecore.Dropkick.BuildNotification.Events;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBuildNotificationService
    {
        EventHandler<OnBuildCompletedEventArgs> OnBuildCompleted { get; set; }

        bool IsNewBuildAvailable();
    }
}
