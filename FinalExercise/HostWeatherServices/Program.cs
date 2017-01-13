using System;
using System.ServiceModel;
using WeatherServices;
using System.ServiceModel.Description;

namespace HostWeatherServices
{
    class Program
    {
        static ServiceHost host = null;

        static void StartService()
        {
            host = new ServiceHost(typeof(WeatherServices.WeatherServices));
            //BEGIN Use this block if NOT using App.config
                        host.AddServiceEndpoint(new ServiceEndpoint(
                            ContractDescription.GetContract(typeof(IWeatherServices)),
                            new NetTcpBinding(SecurityMode.None),
                            new EndpointAddress("net.tcp://localhost:8734/weatherservices")));
            //END Use this block if NOT using App.config
            host.Open();
        }

        static void CloseService()
        {
            if (host.State != CommunicationState.Closed)
            {
                host.Close();
            }
        }
        static void Main(string[] args)
        {
            StartService();

            Console.WriteLine("Weather Service is running....");
            Console.ReadKey();

            CloseService();
        }
    }
}
