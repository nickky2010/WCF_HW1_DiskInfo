﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiskInfoClient.DiskInfoServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DiskInfoServiceReference.IDiskInfoContract")]
    public interface IDiskInfoContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskInfoContract/GetDiskInfo", ReplyAction="http://tempuri.org/IDiskInfoContract/GetDiskInfoResponse")]
        string[] GetDiskInfo(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskInfoContract/GetDiskInfo", ReplyAction="http://tempuri.org/IDiskInfoContract/GetDiskInfoResponse")]
        System.Threading.Tasks.Task<string[]> GetDiskInfoAsync(string path);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDiskInfoContractChannel : DiskInfoClient.DiskInfoServiceReference.IDiskInfoContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DiskInfoContractClient : System.ServiceModel.ClientBase<DiskInfoClient.DiskInfoServiceReference.IDiskInfoContract>, DiskInfoClient.DiskInfoServiceReference.IDiskInfoContract {
        
        public DiskInfoContractClient() {
        }
        
        public DiskInfoContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DiskInfoContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DiskInfoContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DiskInfoContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetDiskInfo(string path) {
            return base.Channel.GetDiskInfo(path);
        }
        
        public System.Threading.Tasks.Task<string[]> GetDiskInfoAsync(string path) {
            return base.Channel.GetDiskInfoAsync(path);
        }
    }
}
