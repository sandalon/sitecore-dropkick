namespace Dropkick.Feature.VSTSBuildNotification.Services
{
    using Dropkick.Feature.VSTSBuildNotification.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IVSTSService
    {
        Task<BuildsDTO> GetBuildsAsync(int buildDefinitionId);
    }
}
