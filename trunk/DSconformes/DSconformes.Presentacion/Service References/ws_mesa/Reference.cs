﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.17929
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSconformes.Presentacion.ws_mesa {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Mesas", Namespace="http://schemas.datacontract.org/2004/07/DSconformes.PlatosService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Mesas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int asientosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_mesaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DSconformes.Presentacion.ws_mesa.Zonas zonaField;
        
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
        public int asientos {
            get {
                return this.asientosField;
            }
            set {
                if ((this.asientosField.Equals(value) != true)) {
                    this.asientosField = value;
                    this.RaisePropertyChanged("asientos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int estado {
            get {
                return this.estadoField;
            }
            set {
                if ((this.estadoField.Equals(value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_mesa {
            get {
                return this.id_mesaField;
            }
            set {
                if ((this.id_mesaField.Equals(value) != true)) {
                    this.id_mesaField = value;
                    this.RaisePropertyChanged("id_mesa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DSconformes.Presentacion.ws_mesa.Zonas zona {
            get {
                return this.zonaField;
            }
            set {
                if ((object.ReferenceEquals(this.zonaField, value) != true)) {
                    this.zonaField = value;
                    this.RaisePropertyChanged("zona");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Zonas", Namespace="http://schemas.datacontract.org/2004/07/DSconformes.PlatosService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Zonas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int capacidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_zonaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
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
        public int capacidad {
            get {
                return this.capacidadField;
            }
            set {
                if ((this.capacidadField.Equals(value) != true)) {
                    this.capacidadField = value;
                    this.RaisePropertyChanged("capacidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_zona {
            get {
                return this.id_zonaField;
            }
            set {
                if ((this.id_zonaField.Equals(value) != true)) {
                    this.id_zonaField = value;
                    this.RaisePropertyChanged("id_zona");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ws_mesa.IMesa")]
    public interface IMesa {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMesa/ListarMesasporZona", ReplyAction="http://tempuri.org/IMesa/ListarMesasporZonaResponse")]
        DSconformes.Presentacion.ws_mesa.Mesas[] ListarMesasporZona(int id_zona);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMesaChannel : DSconformes.Presentacion.ws_mesa.IMesa, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MesaClient : System.ServiceModel.ClientBase<DSconformes.Presentacion.ws_mesa.IMesa>, DSconformes.Presentacion.ws_mesa.IMesa {
        
        public MesaClient() {
        }
        
        public MesaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MesaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MesaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MesaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DSconformes.Presentacion.ws_mesa.Mesas[] ListarMesasporZona(int id_zona) {
            return base.Channel.ListarMesasporZona(id_zona);
        }
    }
}
