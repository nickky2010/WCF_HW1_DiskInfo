using DiskInfo;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(DiskInfoService), new Uri("http://localhost:8733/"));
            host.AddServiceEndpoint(typeof(IDiskInfoContract), new WSHttpBinding(), "DiskInfoService/ep1");
            //Добавляем поведение mex-точки ServiceMetadataBehavior в коллекцию поведений основного приложения службы
            host.Description.Behaviors.Add(new ServiceMetadataBehavior());
            //Добавляем конечную точку обмена метаданными в ведущее приложение службы   
            host.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName,
                             MetadataExchangeBindings.CreateMexHttpBinding(),
                             "mex");
            host.Open();
            Console.WriteLine("Service is waiting for customer requests...");
            Console.ReadKey();
            host.Close();
        }
    }
}
