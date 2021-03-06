﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WavecellTest.Wavecell {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://wavecell.com/", ConfigurationName="Wavecell.SendSoap")]
    public interface SendSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wavecell.com/SendMT", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendMT(string AccountId, string SubAccountId, string Password, string UMID, string Destination, string Source, string Body, string Encoding, string ScheduledDateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wavecell.com/SendWapPush", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendWapPush(string AccountId, string SubAccountId, string Password, string UMID, string Destination, string Source, string Body, string WapUrl, string Encoding, string ScheduledDateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://wavecell.com/SendMO", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendMO(string Password, string Source, string Destination, string OperatorId, string Body, string Encoding);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SendSoapChannel : WavecellTest.Wavecell.SendSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendSoapClient : System.ServiceModel.ClientBase<WavecellTest.Wavecell.SendSoap>, WavecellTest.Wavecell.SendSoap {
        
        public SendSoapClient() {
        }
        
        public SendSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SendSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SendMT(string AccountId, string SubAccountId, string Password, string UMID, string Destination, string Source, string Body, string Encoding, string ScheduledDateTime) {
            return base.Channel.SendMT(AccountId, SubAccountId, Password, UMID, Destination, Source, Body, Encoding, ScheduledDateTime);
        }
        
        public string SendWapPush(string AccountId, string SubAccountId, string Password, string UMID, string Destination, string Source, string Body, string WapUrl, string Encoding, string ScheduledDateTime) {
            return base.Channel.SendWapPush(AccountId, SubAccountId, Password, UMID, Destination, Source, Body, WapUrl, Encoding, ScheduledDateTime);
        }
        
        public string SendMO(string Password, string Source, string Destination, string OperatorId, string Body, string Encoding) {
            return base.Channel.SendMO(Password, Source, Destination, OperatorId, Body, Encoding);
        }
    }
}
