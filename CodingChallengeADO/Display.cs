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
    class Display
    {
        public string FetchByName()
        {
            Console.WriteLine("Enter Track Name ");
            string trackName = Input.StringInput();

            FetchByTrackName fetchByTrackName = new FetchByTrackName();
            List<Capability> capability = fetchByTrackName.FetchData(trackName);

            foreach (Capability data in capability)
            {
                Console.WriteLine("Capability Id :"+data.CapabilityId);
                Console.WriteLine("Track Id      :"+data.TrackId);
                Console.WriteLine("Ko's          :");
                int index = 0;
                int total = data.Ko.Count();
                while(index<total)
                {
                    Console.WriteLine(data.Ko[index++]);
                }

                Console.WriteLine("Non Ko's       :");
                index = 0;
                total = data.NonKo.Count();
                while (index < total)
                {
                    Console.WriteLine(data.NonKo[index++]);
                }

                Console.WriteLine("Summary       :");
                Console.WriteLine(data.Summary);
            }

            return "Successfully Executed";
        }
    }
}
