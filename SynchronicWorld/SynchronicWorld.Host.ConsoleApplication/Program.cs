using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SynchronicWorld.Host.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri endPointAddress = new Uri("http://localhost:8173/SynchronicWorldService.svc");
            using (ServiceHost serviceHost = new ServiceHost(typeof(SynchronicWorldServiceReference.SynchronicWorldServiceClient), endPointAddress))
            {

                try
                {
                    serviceHost.AddServiceEndpoint(typeof(SynchronicWorldServiceReference.ISynchronicWorldService), new BasicHttpBinding(), "");

                    serviceHost.UnknownMessageReceived += serviceHost_UnknownMessageReceived;
                    serviceHost.Open();

                    Console.WriteLine("The service is ready.");
                    Console.WriteLine("Press <ENTER> to terminate service.");
                    Console.ReadLine();

                    serviceHost.Close();
                }
                catch (TimeoutException timeProblem)
                {
                    Console.WriteLine(timeProblem.Message);
                    Console.ReadLine();
                }
                catch (CommunicationException commProblem)
                {
                    Console.WriteLine(commProblem.Message);
                    Console.ReadLine();
                }
            }
        }

        static void serviceHost_UnknownMessageReceived(object sender, UnknownMessageReceivedEventArgs e)
        {
            Console.WriteLine("Unknown message received: " + e.Message);
        }
    }
}
