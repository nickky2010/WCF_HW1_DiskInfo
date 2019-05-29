using DiskInfoClient.DiskInfoServiceReference;
using System;
using System.IO;
using System.ServiceModel;

namespace DiskInfoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IDiskInfoContract> factory = new ChannelFactory<IDiskInfoContract>(new WSHttpBinding(), new EndpointAddress("http://localhost:8733/DiskInfoService/ep1"));
            IDiskInfoContract channel = factory.CreateChannel();
            Console.Write("Content for path: ");
            string path = Console.ReadLine();
            Console.WriteLine();
            string[] pathContent = channel.GetDiskInfo(path);
            if (pathContent!=null)
            {
                Console.WriteLine(String.Format("{0,10}{1,60}", "Name", "Type"));
                foreach (var item in pathContent)
                {
                    string ext = Path.GetExtension(item);
                    if(ext.Length>1&&ext.Length<7)
                        Console.WriteLine(String.Format("{0,-60:N0}{1,10:N0}", item, "file"));
                    else
                        Console.WriteLine(String.Format("{0,-60:N0}{1,10:N0}", item, "folder"));
                }
            }
            else
            {
                Console.WriteLine("Server returned null. Perhaps your path is wrong.");
            }
            Console.Write("\nFor exit press any key...");
            Console.ReadKey();
        }
    }
}
