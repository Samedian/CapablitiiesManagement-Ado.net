using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Track
    {
        public Track(int TrackId,string TrackName)
        {
            this.TrackId = TrackId;
            this.TrackName = TrackName;
        }

        public int TrackId { get; set; }

        public string TrackName { get; set; }


    }
}
