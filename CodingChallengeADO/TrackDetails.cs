using BussinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Assignment2;

namespace CodingChallengeADO
{
    class TrackDetails
    {
        public string AddData()
        {
            Console.WriteLine("Enter Track Id :");
            int trackId = Input.PositiveInteger();

            Console.WriteLine("Enter Track Name :");
            string trackName = Input.StringInput();

            Track track = new Track(trackId, trackName);

            TrackBussinessLayer trackBussinessLayer = new TrackBussinessLayer();
            string msg = trackBussinessLayer.AddTrack(track);

            return msg;
        }
    }
}
