﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBL.CPS.UI.srTipoGrupo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoGrupoFTR", Namespace="http://schemas.datacontract.org/2004/07/IBL.CPS.DTO")]
    [System.SerializableAttribute()]
    public partial class TipoGrupoFTR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descricaoField;
        
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
        public string descricao {
            get {
                return this.descricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.descricaoField, value) != true)) {
                    this.descricaoField = value;
                    this.RaisePropertyChanged("descricao");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoGrupoDTO", Namespace="http://schemas.datacontract.org/2004/07/IBL.CPS.DTO")]
    [System.SerializableAttribute()]
    public partial class TipoGrupoDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DESCRICAOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
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
        public string DESCRICAO {
            get {
                return this.DESCRICAOField;
            }
            set {
                if ((object.ReferenceEquals(this.DESCRICAOField, value) != true)) {
                    this.DESCRICAOField = value;
                    this.RaisePropertyChanged("DESCRICAO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TokenFaultContract", Namespace="http://schemas.datacontract.org/2004/07/IBL.CPS.SERVICOS")]
    [System.SerializableAttribute()]
    public partial class TokenFaultContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
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
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srTipoGrupo.IServiceTipoGrupo")]
    public interface IServiceTipoGrupo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/ObterLista", ReplyAction="http://tempuri.org/IServiceTipoGrupo/ObterListaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(IBL.CPS.UI.srTipoGrupo.TokenFaultContract), Action="http://tempuri.org/IServiceTipoGrupo/ObterListaTokenFaultContractFault", Name="TokenFaultContract", Namespace="http://schemas.datacontract.org/2004/07/IBL.CPS.SERVICOS")]
        IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO[] ObterLista(IBL.CPS.UI.srTipoGrupo.TipoGrupoFTR Filtro, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/ObterLista", ReplyAction="http://tempuri.org/IServiceTipoGrupo/ObterListaResponse")]
        System.Threading.Tasks.Task<IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO[]> ObterListaAsync(IBL.CPS.UI.srTipoGrupo.TipoGrupoFTR Filtro, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/Incluir", ReplyAction="http://tempuri.org/IServiceTipoGrupo/IncluirResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(IBL.CPS.UI.srTipoGrupo.TokenFaultContract), Action="http://tempuri.org/IServiceTipoGrupo/IncluirTokenFaultContractFault", Name="TokenFaultContract", Namespace="http://schemas.datacontract.org/2004/07/IBL.CPS.SERVICOS")]
        void Incluir(IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO dto, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/Incluir", ReplyAction="http://tempuri.org/IServiceTipoGrupo/IncluirResponse")]
        System.Threading.Tasks.Task IncluirAsync(IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO dto, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/Gravar", ReplyAction="http://tempuri.org/IServiceTipoGrupo/GravarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(IBL.CPS.UI.srTipoGrupo.TokenFaultContract), Action="http://tempuri.org/IServiceTipoGrupo/GravarTokenFaultContractFault", Name="TokenFaultContract", Namespace="http://schemas.datacontract.org/2004/07/IBL.CPS.SERVICOS")]
        void Gravar(IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO dto, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/Gravar", ReplyAction="http://tempuri.org/IServiceTipoGrupo/GravarResponse")]
        System.Threading.Tasks.Task GravarAsync(IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO dto, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/Excluir", ReplyAction="http://tempuri.org/IServiceTipoGrupo/ExcluirResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(IBL.CPS.UI.srTipoGrupo.TokenFaultContract), Action="http://tempuri.org/IServiceTipoGrupo/ExcluirTokenFaultContractFault", Name="TokenFaultContract", Namespace="http://schemas.datacontract.org/2004/07/IBL.CPS.SERVICOS")]
        void Excluir(int id, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/Excluir", ReplyAction="http://tempuri.org/IServiceTipoGrupo/ExcluirResponse")]
        System.Threading.Tasks.Task ExcluirAsync(int id, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/Obter", ReplyAction="http://tempuri.org/IServiceTipoGrupo/ObterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(IBL.CPS.UI.srTipoGrupo.TokenFaultContract), Action="http://tempuri.org/IServiceTipoGrupo/ObterTokenFaultContractFault", Name="TokenFaultContract", Namespace="http://schemas.datacontract.org/2004/07/IBL.CPS.SERVICOS")]
        IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO Obter(int id, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceTipoGrupo/Obter", ReplyAction="http://tempuri.org/IServiceTipoGrupo/ObterResponse")]
        System.Threading.Tasks.Task<IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO> ObterAsync(int id, string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceTipoGrupoChannel : IBL.CPS.UI.srTipoGrupo.IServiceTipoGrupo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceTipoGrupoClient : System.ServiceModel.ClientBase<IBL.CPS.UI.srTipoGrupo.IServiceTipoGrupo>, IBL.CPS.UI.srTipoGrupo.IServiceTipoGrupo {
        
        public ServiceTipoGrupoClient() {
        }
        
        public ServiceTipoGrupoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceTipoGrupoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTipoGrupoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTipoGrupoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO[] ObterLista(IBL.CPS.UI.srTipoGrupo.TipoGrupoFTR Filtro, string token) {
            return base.Channel.ObterLista(Filtro, token);
        }
        
        public System.Threading.Tasks.Task<IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO[]> ObterListaAsync(IBL.CPS.UI.srTipoGrupo.TipoGrupoFTR Filtro, string token) {
            return base.Channel.ObterListaAsync(Filtro, token);
        }
        
        public void Incluir(IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO dto, string token) {
            base.Channel.Incluir(dto, token);
        }
        
        public System.Threading.Tasks.Task IncluirAsync(IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO dto, string token) {
            return base.Channel.IncluirAsync(dto, token);
        }
        
        public void Gravar(IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO dto, string token) {
            base.Channel.Gravar(dto, token);
        }
        
        public System.Threading.Tasks.Task GravarAsync(IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO dto, string token) {
            return base.Channel.GravarAsync(dto, token);
        }
        
        public void Excluir(int id, string token) {
            base.Channel.Excluir(id, token);
        }
        
        public System.Threading.Tasks.Task ExcluirAsync(int id, string token) {
            return base.Channel.ExcluirAsync(id, token);
        }
        
        public IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO Obter(int id, string token) {
            return base.Channel.Obter(id, token);
        }
        
        public System.Threading.Tasks.Task<IBL.CPS.UI.srTipoGrupo.TipoGrupoDTO> ObterAsync(int id, string token) {
            return base.Channel.ObterAsync(id, token);
        }
    }
}
