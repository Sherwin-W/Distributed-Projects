﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project4_Tryit.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchXmlContent", ReplyAction="http://tempuri.org/IService1/SearchXmlContentResponse")]
        string[] SearchXmlContent(string xmlUrl, string searchKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchXmlContent", ReplyAction="http://tempuri.org/IService1/SearchXmlContentResponse")]
        System.Threading.Tasks.Task<string[]> SearchXmlContentAsync(string xmlUrl, string searchKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerifyXmlWithXsd", ReplyAction="http://tempuri.org/IService1/VerifyXmlWithXsdResponse")]
        string VerifyXmlWithXsd(string xmlUrl, string xsdUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/VerifyXmlWithXsd", ReplyAction="http://tempuri.org/IService1/VerifyXmlWithXsdResponse")]
        System.Threading.Tasks.Task<string> VerifyXmlWithXsdAsync(string xmlUrl, string xsdUrl);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Project4_Tryit.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Project4_Tryit.ServiceReference1.IService1>, Project4_Tryit.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] SearchXmlContent(string xmlUrl, string searchKey) {
            return base.Channel.SearchXmlContent(xmlUrl, searchKey);
        }
        
        public System.Threading.Tasks.Task<string[]> SearchXmlContentAsync(string xmlUrl, string searchKey) {
            return base.Channel.SearchXmlContentAsync(xmlUrl, searchKey);
        }
        
        public string VerifyXmlWithXsd(string xmlUrl, string xsdUrl) {
            return base.Channel.VerifyXmlWithXsd(xmlUrl, xsdUrl);
        }
        
        public System.Threading.Tasks.Task<string> VerifyXmlWithXsdAsync(string xmlUrl, string xsdUrl) {
            return base.Channel.VerifyXmlWithXsdAsync(xmlUrl, xsdUrl);
        }
    }
}
