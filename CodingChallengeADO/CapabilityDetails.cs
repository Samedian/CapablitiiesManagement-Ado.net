using Entities;
using System;
using System.Collections.Generic;
using BussinessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Assignment2;

namespace CodingChallengeADO
{
    class CapabilityDetails
    {
        public string AddCapability()
        {
            int number;
            List<string> Ko = new List<string>();
            List<string> NonKo = new List<string>();

            Console.WriteLine("Enter Track Id");
            int trackId = Input.PositiveInteger();

            Console.WriteLine("Enter Number of Ko's");
            number = Input.PositiveInteger();

            while(number--!=0)
            {
                Console.WriteLine("Enter Ko ");
                string str = Input.StringInput();

                Ko.Add(str);
            }

            Console.WriteLine("Enter Number of Non Ko's");
            number = Input.PositiveInteger();

            while (number-- != 0)
            {
                Console.WriteLine("Enter Non  Ko ");
                string str = Input.StringInput();

                NonKo.Add(str);
            }

            Console.WriteLine("Enter Summary ");
            string summary = Input.StringInput();

            Capability capability = new Capability(Ko, NonKo, summary, trackId);
            CapabilityBussinessLayer capabilityBussinessLayer = new CapabilityBussinessLayer();
            string msg = capabilityBussinessLayer.AddCapability(capability);

            return msg;

        }
    }
}
