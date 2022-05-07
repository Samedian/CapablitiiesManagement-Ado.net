using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Assignment2;

namespace CodingChallengeADO
{
    class Program
    {
        static void Main(string[] args)
        {

            char ch;
            string msg;

            do
            {
                Console.WriteLine("1.Add Track");
                Console.WriteLine("2.Add Capabilities");
                Console.WriteLine("3.Display Capability based on Track ");

                int choice = Input.PositiveInteger();

                switch(choice)
                {
                    case 1:
                        TrackDetails track = new TrackDetails();
                        msg = track.AddData();
                        Console.WriteLine(msg);
                        break;
                    case 2:
                        CapabilityDetails capability = new CapabilityDetails();
                        msg = capability.AddCapability();
                        Console.WriteLine(msg);
                        break;
                    case 3:
                        Display display = new Display();
                        msg = display.FetchByName();
                        Console.WriteLine(msg);
                        break;



                }
                Console.WriteLine("Do you want to continue ");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');
        }
    }
}
