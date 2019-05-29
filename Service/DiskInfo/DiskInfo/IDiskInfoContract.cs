using System.ServiceModel;

namespace DiskInfo
{
    [ServiceContract]
    public interface IDiskInfoContract
    {
        [OperationContract]
        string[] GetDiskInfo(string path);
    }
}
