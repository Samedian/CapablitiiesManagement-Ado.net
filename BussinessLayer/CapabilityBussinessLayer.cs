using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CapabilityBussinessLayer
    {
        public string AddCapability(Capability capability)
        {
            CapabilityDataAccessLayer capabilityDataAccessLayer = new CapabilityDataAccessLayer();
            string msg = capabilityDataAccessLayer.AddCapabilityToDataBase(capability);

            return msg;
        }
    }
}
