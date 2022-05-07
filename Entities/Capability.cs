using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Capability
    {
        public Capability()
        {

        }
        public Capability(List<string> Ko, List<string> NonKo,string Summary,int TrackId)
        {
            this.Ko = Ko;
            this.NonKo = NonKo;
            this.Summary = Summary;
            this.TrackId = TrackId;
        }
        public int CapabilityId { get; set; }
       
        public int TrackId { get; set; }

        public List<string> Ko { get; set; }

        public List<string> NonKo { get; set; }

        public string Summary { get; set; }
      


    }
}
