using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using Remote_Objects;


namespace Console_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //HttpChannel cc = new HttpChannel(8003);
            //ChannelServices.RegisterChannel(cc);

            //create a service class object
            Service service = (Service)Activator.GetObject(typeof(Service),
                "http://localhost:87/RServices");

            //start calling the functions of the remote object
            Console.WriteLine(service.SayHello("Infinite Associates"));
            Console.WriteLine(service.HighestNumber(12,46));

            Console.Read();

        }
    }
}
