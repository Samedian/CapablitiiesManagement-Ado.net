using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TrackBussinessLayer
    {
        public string AddTrack(Track track)
        {
            TrackDataAccessLayer trackDataAccessLayer = new TrackDataAccessLayer();
            string msg = trackDataAccessLayer.AddTrackToDataBase(track);
            return msg;
        }
    }
}
