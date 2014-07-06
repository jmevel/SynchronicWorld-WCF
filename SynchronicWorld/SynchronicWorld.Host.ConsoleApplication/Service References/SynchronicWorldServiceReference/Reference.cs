﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/SynchronicWorld.Models")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NicknameField;
        
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
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
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
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nickname {
            get {
                return this.NicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.NicknameField, value) != true)) {
                    this.NicknameField = value;
                    this.RaisePropertyChanged("Nickname");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://schemas.datacontract.org/2004/07/SynchronicWorld.Models")]
    [System.SerializableAttribute()]
    public partial class Event : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution[] ContributionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person[] PersonsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.EventStatus StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.EventType TypeField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution[] Contributions {
            get {
                return this.ContributionsField;
            }
            set {
                if ((object.ReferenceEquals(this.ContributionsField, value) != true)) {
                    this.ContributionsField = value;
                    this.RaisePropertyChanged("Contributions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person[] Persons {
            get {
                return this.PersonsField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonsField, value) != true)) {
                    this.PersonsField = value;
                    this.RaisePropertyChanged("Persons");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.EventStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.EventType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contribution", Namespace="http://schemas.datacontract.org/2004/07/SynchronicWorld.Models")]
    [System.SerializableAttribute()]
    public partial class Contribution : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event EventField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person PersonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.ContributionType TypeField;
        
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
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event Event {
            get {
                return this.EventField;
            }
            set {
                if ((object.ReferenceEquals(this.EventField, value) != true)) {
                    this.EventField = value;
                    this.RaisePropertyChanged("Event");
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person Person {
            get {
                return this.PersonField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonField, value) != true)) {
                    this.PersonField = value;
                    this.RaisePropertyChanged("Person");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((object.ReferenceEquals(this.QuantityField, value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.ContributionType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventStatus", Namespace="http://schemas.datacontract.org/2004/07/SynchronicWorld.Models")]
    public enum EventStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Open = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Closed = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pending = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventType", Namespace="http://schemas.datacontract.org/2004/07/SynchronicWorld.Models")]
    public enum EventType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Party = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Lunch = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ContributionType", Namespace="http://schemas.datacontract.org/2004/07/SynchronicWorld.Models")]
    public enum ContributionType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Money = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Food = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Beverage = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SynchronicWorldServiceReference.ISynchronicWorldService")]
    public interface ISynchronicWorldService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetAllPersons", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetAllPersonsResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person[] GetAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/CreatePerson", ReplyAction="http://tempuri.org/ISynchronicWorldService/CreatePersonResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person CreatePerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetPersonByNickname", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetPersonByNicknameResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person GetPersonByNickname(string nickname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/UpdatePerson", ReplyAction="http://tempuri.org/ISynchronicWorldService/UpdatePersonResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person UpdatePerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person updatedPerson);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/DeletePerson", ReplyAction="http://tempuri.org/ISynchronicWorldService/DeletePersonResponse")]
        bool DeletePerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetAllEvents", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetAllEventsResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetAllEvents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/CreateEvent", ReplyAction="http://tempuri.org/ISynchronicWorldService/CreateEventResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event CreateEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventToCreate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetEventByName", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetEventByNameResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event GetEventByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/UpdateEvent", ReplyAction="http://tempuri.org/ISynchronicWorldService/UpdateEventResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event UpdateEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event updatedEvent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/DeleteEvent", ReplyAction="http://tempuri.org/ISynchronicWorldService/DeleteEventResponse")]
        bool DeleteEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventToDelete);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetAllContributions", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetAllContributionsResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution[] GetAllContributions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/CreateContribution", ReplyAction="http://tempuri.org/ISynchronicWorldService/CreateContributionResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution CreateContribution(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution contribution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetContributionByName", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetContributionByNameResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution GetContributionByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/AddContribution", ReplyAction="http://tempuri.org/ISynchronicWorldService/AddContributionResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event AddContribution(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution contribution, SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventTarget);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetEventsByDate", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetEventsByDateResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetEventsByDate(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetEventsBetweenTwoDates", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetEventsBetweenTwoDatesResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetEventsBetweenTwoDates(System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetEventsByStatus", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetEventsByStatusResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetEventsByStatus(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.EventStatus status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetEventsByType", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetEventsByTypeResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetEventsByType(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.EventType type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/DeleteClosedEvents", ReplyAction="http://tempuri.org/ISynchronicWorldService/DeleteClosedEventsResponse")]
        bool DeleteClosedEvents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/UpdatePendingEvents", ReplyAction="http://tempuri.org/ISynchronicWorldService/UpdatePendingEventsResponse")]
        bool UpdatePendingEvents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/AddPersonToOpenEvent", ReplyAction="http://tempuri.org/ISynchronicWorldService/AddPersonToOpenEventResponse")]
        bool AddPersonToOpenEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventTarget, SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetAllPersonsFromOpenEvent", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetAllPersonsFromOpenEventResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person[] GetAllPersonsFromOpenEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventTarget);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetAllContributionsFromEvent", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetAllContributionsFromEventResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution[] GetAllContributionsFromEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventTarget);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/GetAllContributionsFromPerson", ReplyAction="http://tempuri.org/ISynchronicWorldService/GetAllContributionsFromPersonResponse")]
        SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution[] GetAllContributionsFromPerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynchronicWorldService/DeleteAllContributionsForAllOpenEvents" +
            "FromPerson", ReplyAction="http://tempuri.org/ISynchronicWorldService/DeleteAllContributionsForAllOpenEvents" +
            "FromPersonResponse")]
        bool DeleteAllContributionsForAllOpenEventsFromPerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISynchronicWorldServiceChannel : SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.ISynchronicWorldService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SynchronicWorldServiceClient : System.ServiceModel.ClientBase<SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.ISynchronicWorldService>, SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.ISynchronicWorldService {
        
        public SynchronicWorldServiceClient() {
        }
        
        public SynchronicWorldServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SynchronicWorldServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SynchronicWorldServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SynchronicWorldServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person[] GetAllPersons() {
            return base.Channel.GetAllPersons();
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person CreatePerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person) {
            return base.Channel.CreatePerson(person);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person GetPersonByNickname(string nickname) {
            return base.Channel.GetPersonByNickname(nickname);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person UpdatePerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person updatedPerson) {
            return base.Channel.UpdatePerson(updatedPerson);
        }
        
        public bool DeletePerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person) {
            return base.Channel.DeletePerson(person);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetAllEvents() {
            return base.Channel.GetAllEvents();
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event CreateEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventToCreate) {
            return base.Channel.CreateEvent(eventToCreate);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event GetEventByName(string name) {
            return base.Channel.GetEventByName(name);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event UpdateEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event updatedEvent) {
            return base.Channel.UpdateEvent(updatedEvent);
        }
        
        public bool DeleteEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventToDelete) {
            return base.Channel.DeleteEvent(eventToDelete);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution[] GetAllContributions() {
            return base.Channel.GetAllContributions();
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution CreateContribution(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution contribution) {
            return base.Channel.CreateContribution(contribution);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution GetContributionByName(string name) {
            return base.Channel.GetContributionByName(name);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event AddContribution(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution contribution, SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventTarget) {
            return base.Channel.AddContribution(contribution, eventTarget);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetEventsByDate(System.DateTime date) {
            return base.Channel.GetEventsByDate(date);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetEventsBetweenTwoDates(System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetEventsBetweenTwoDates(startDate, endDate);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetEventsByStatus(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.EventStatus status) {
            return base.Channel.GetEventsByStatus(status);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event[] GetEventsByType(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.EventType type) {
            return base.Channel.GetEventsByType(type);
        }
        
        public bool DeleteClosedEvents() {
            return base.Channel.DeleteClosedEvents();
        }
        
        public bool UpdatePendingEvents() {
            return base.Channel.UpdatePendingEvents();
        }
        
        public bool AddPersonToOpenEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventTarget, SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person) {
            return base.Channel.AddPersonToOpenEvent(eventTarget, person);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person[] GetAllPersonsFromOpenEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventTarget) {
            return base.Channel.GetAllPersonsFromOpenEvent(eventTarget);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution[] GetAllContributionsFromEvent(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Event eventTarget) {
            return base.Channel.GetAllContributionsFromEvent(eventTarget);
        }
        
        public SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Contribution[] GetAllContributionsFromPerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person) {
            return base.Channel.GetAllContributionsFromPerson(person);
        }
        
        public bool DeleteAllContributionsForAllOpenEventsFromPerson(SynchronicWorld.Host.ConsoleApplication.SynchronicWorldServiceReference.Person person) {
            return base.Channel.DeleteAllContributionsForAllOpenEventsFromPerson(person);
        }
    }
}
