﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.17929
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSconformes.Presentacion.ws_reserva {
    using System.Runtime.Serialization;
    using System;
    
    
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
        private string descripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool habilitadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_zonaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int minimoField;
        
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
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool habilitado {
            get {
                return this.habilitadoField;
            }
            set {
                if ((this.habilitadoField.Equals(value) != true)) {
                    this.habilitadoField = value;
                    this.RaisePropertyChanged("habilitado");
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
        public int minimo {
            get {
                return this.minimoField;
            }
            set {
                if ((this.minimoField.Equals(value) != true)) {
                    this.minimoField = value;
                    this.RaisePropertyChanged("minimo");
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
        private DSconformes.Presentacion.ws_reserva.Zonas zonaField;
        
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
        public DSconformes.Presentacion.ws_reserva.Zonas zona {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Reservas", Namespace="http://schemas.datacontract.org/2004/07/DSconformes.PlatosService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Reservas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int asistentesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan hora_inicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_mesaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_reservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DSconformes.Presentacion.ws_reserva.Mesas mesaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal total_consumoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DSconformes.Presentacion.ws_reserva.Zonas zonaField;
        
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
        public int asistentes {
            get {
                return this.asistentesField;
            }
            set {
                if ((this.asistentesField.Equals(value) != true)) {
                    this.asistentesField = value;
                    this.RaisePropertyChanged("asistentes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dni {
            get {
                return this.dniField;
            }
            set {
                if ((object.ReferenceEquals(this.dniField, value) != true)) {
                    this.dniField = value;
                    this.RaisePropertyChanged("dni");
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
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan hora_inicio {
            get {
                return this.hora_inicioField;
            }
            set {
                if ((this.hora_inicioField.Equals(value) != true)) {
                    this.hora_inicioField = value;
                    this.RaisePropertyChanged("hora_inicio");
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
        public int id_reserva {
            get {
                return this.id_reservaField;
            }
            set {
                if ((this.id_reservaField.Equals(value) != true)) {
                    this.id_reservaField = value;
                    this.RaisePropertyChanged("id_reserva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DSconformes.Presentacion.ws_reserva.Mesas mesa {
            get {
                return this.mesaField;
            }
            set {
                if ((object.ReferenceEquals(this.mesaField, value) != true)) {
                    this.mesaField = value;
                    this.RaisePropertyChanged("mesa");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal total_consumo {
            get {
                return this.total_consumoField;
            }
            set {
                if ((this.total_consumoField.Equals(value) != true)) {
                    this.total_consumoField = value;
                    this.RaisePropertyChanged("total_consumo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DSconformes.Presentacion.ws_reserva.Zonas zona {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ws_reserva.IReserva")]
    public interface IReserva {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReserva/Registrar", ReplyAction="http://tempuri.org/IReserva/RegistrarResponse")]
        DSconformes.Presentacion.ws_reserva.Reservas Registrar(string nombre, string dni, DSconformes.Presentacion.ws_reserva.Zonas zona, DSconformes.Presentacion.ws_reserva.Mesas mesa, System.TimeSpan hora_inicio, int estado, int asistentes, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReserva/Listar", ReplyAction="http://tempuri.org/IReserva/ListarResponse")]
        DSconformes.Presentacion.ws_reserva.Reservas[] Listar(string nombre, string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReserva/Obtener", ReplyAction="http://tempuri.org/IReserva/ObtenerResponse")]
        DSconformes.Presentacion.ws_reserva.Reservas Obtener(int id_reserva);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReservaChannel : DSconformes.Presentacion.ws_reserva.IReserva, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReservaClient : System.ServiceModel.ClientBase<DSconformes.Presentacion.ws_reserva.IReserva>, DSconformes.Presentacion.ws_reserva.IReserva {
        
        public ReservaClient() {
        }
        
        public ReservaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReservaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DSconformes.Presentacion.ws_reserva.Reservas Registrar(string nombre, string dni, DSconformes.Presentacion.ws_reserva.Zonas zona, DSconformes.Presentacion.ws_reserva.Mesas mesa, System.TimeSpan hora_inicio, int estado, int asistentes, System.DateTime fecha) {
            return base.Channel.Registrar(nombre, dni, zona, mesa, hora_inicio, estado, asistentes, fecha);
        }
        
        public DSconformes.Presentacion.ws_reserva.Reservas[] Listar(string nombre, string dni) {
            return base.Channel.Listar(nombre, dni);
        }
        
        public DSconformes.Presentacion.ws_reserva.Reservas Obtener(int id_reserva) {
            return base.Channel.Obtener(id_reserva);
        }
    }
}
