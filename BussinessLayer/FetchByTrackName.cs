using Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class FetchByTrackName
    {

        public List<Capability> FetchData(string trackName)
        {
            FetchDataBase fetchData = new FetchDataBase();
            List<Capability> capability = fetchData.Fetch(trackName);

            return capability;
        }
    }
}
