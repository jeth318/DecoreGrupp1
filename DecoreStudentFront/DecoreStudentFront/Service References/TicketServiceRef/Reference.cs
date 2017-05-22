﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DecoreStudentFront.TicketServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ticket", Namespace="http://schemas.datacontract.org/2004/07/Decore.Models")]
    [System.SerializableAttribute()]
    public partial class Ticket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountOfTicketsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BoughtAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EventIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AmountOfTickets {
            get {
                return this.AmountOfTicketsField;
            }
            set {
                if ((this.AmountOfTicketsField.Equals(value) != true)) {
                    this.AmountOfTicketsField = value;
                    this.RaisePropertyChanged("AmountOfTickets");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime BoughtAt {
            get {
                return this.BoughtAtField;
            }
            set {
                if ((this.BoughtAtField.Equals(value) != true)) {
                    this.BoughtAtField = value;
                    this.RaisePropertyChanged("BoughtAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EventId {
            get {
                return this.EventIdField;
            }
            set {
                if ((this.EventIdField.Equals(value) != true)) {
                    this.EventIdField = value;
                    this.RaisePropertyChanged("EventId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TicketServiceRef.ITicketService")]
    public interface ITicketService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/GetTickets", ReplyAction="http://tempuri.org/ITicketService/GetTicketsResponse")]
        DecoreStudentFront.TicketServiceRef.Ticket[] GetTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/GetTickets", ReplyAction="http://tempuri.org/ITicketService/GetTicketsResponse")]
        System.Threading.Tasks.Task<DecoreStudentFront.TicketServiceRef.Ticket[]> GetTicketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/CreateTicket", ReplyAction="http://tempuri.org/ITicketService/CreateTicketResponse")]
        void CreateTicket(DecoreStudentFront.TicketServiceRef.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/CreateTicket", ReplyAction="http://tempuri.org/ITicketService/CreateTicketResponse")]
        System.Threading.Tasks.Task CreateTicketAsync(DecoreStudentFront.TicketServiceRef.Ticket ticket);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITicketServiceChannel : DecoreStudentFront.TicketServiceRef.ITicketService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TicketServiceClient : System.ServiceModel.ClientBase<DecoreStudentFront.TicketServiceRef.ITicketService>, DecoreStudentFront.TicketServiceRef.ITicketService {
        
        public TicketServiceClient() {
        }
        
        public TicketServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TicketServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DecoreStudentFront.TicketServiceRef.Ticket[] GetTickets() {
            return base.Channel.GetTickets();
        }
        
        public System.Threading.Tasks.Task<DecoreStudentFront.TicketServiceRef.Ticket[]> GetTicketsAsync() {
            return base.Channel.GetTicketsAsync();
        }
        
        public void CreateTicket(DecoreStudentFront.TicketServiceRef.Ticket ticket) {
            base.Channel.CreateTicket(ticket);
        }
        
        public System.Threading.Tasks.Task CreateTicketAsync(DecoreStudentFront.TicketServiceRef.Ticket ticket) {
            return base.Channel.CreateTicketAsync(ticket);
        }
    }
}