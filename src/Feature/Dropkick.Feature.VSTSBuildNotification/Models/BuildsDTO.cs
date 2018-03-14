namespace Dropkick.Feature.VSTSBuildNotification.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BuildsDTO
    {
        public int Count { get; set; }
        public List<BuildDTO> Value { get; set; }
    }
}
