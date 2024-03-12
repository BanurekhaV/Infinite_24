using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;
using Remote_Objects;

namespace ServerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a channel for communication
            HttpChannel hc = new HttpChannel(87); //port number

            //register the channel
            ChannelServices.RegisterChannel(hc);
            //configure all known services

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "RServices", WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services Startedd at Port No.87....");
            Console.WriteLine("Press any key to stop server services...");
            Console.Read();

        }
    }
}
