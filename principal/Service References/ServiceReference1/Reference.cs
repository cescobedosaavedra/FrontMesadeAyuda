﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace principal.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Empleado", Namespace="http://schemas.datacontract.org/2004/07/Usuarios_SOAPService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Empleado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AreaEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CargoEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoEmpleadoField;
        
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
        public string ApellidoEmpleado {
            get {
                return this.ApellidoEmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoEmpleadoField, value) != true)) {
                    this.ApellidoEmpleadoField = value;
                    this.RaisePropertyChanged("ApellidoEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AreaEmpleado {
            get {
                return this.AreaEmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.AreaEmpleadoField, value) != true)) {
                    this.AreaEmpleadoField = value;
                    this.RaisePropertyChanged("AreaEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CargoEmpleado {
            get {
                return this.CargoEmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.CargoEmpleadoField, value) != true)) {
                    this.CargoEmpleadoField = value;
                    this.RaisePropertyChanged("CargoEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodEmpleado {
            get {
                return this.CodEmpleadoField;
            }
            set {
                if ((this.CodEmpleadoField.Equals(value) != true)) {
                    this.CodEmpleadoField = value;
                    this.RaisePropertyChanged("CodEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CorreoEmpleado {
            get {
                return this.CorreoEmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoEmpleadoField, value) != true)) {
                    this.CorreoEmpleadoField = value;
                    this.RaisePropertyChanged("CorreoEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreEmpleado {
            get {
                return this.NombreEmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreEmpleadoField, value) != true)) {
                    this.NombreEmpleadoField = value;
                    this.RaisePropertyChanged("NombreEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TelefonoEmpleado {
            get {
                return this.TelefonoEmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoEmpleadoField, value) != true)) {
                    this.TelefonoEmpleadoField = value;
                    this.RaisePropertyChanged("TelefonoEmpleado");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IEmpleados")]
    public interface IEmpleados {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/CrearEmpleado", ReplyAction="http://tempuri.org/IEmpleados/CrearEmpleadoResponse")]
        principal.ServiceReference1.Empleado CrearEmpleado(string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/ObtenerEmpleado", ReplyAction="http://tempuri.org/IEmpleados/ObtenerEmpleadoResponse")]
        principal.ServiceReference1.Empleado ObtenerEmpleado(int CodEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/ModificarEmpleado", ReplyAction="http://tempuri.org/IEmpleados/ModificarEmpleadoResponse")]
        principal.ServiceReference1.Empleado ModificarEmpleado(int CodEmpleado, string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/EliminarEmpleado", ReplyAction="http://tempuri.org/IEmpleados/EliminarEmpleadoResponse")]
        principal.ServiceReference1.Empleado EliminarEmpleado(int CodEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/ListarEmpleados", ReplyAction="http://tempuri.org/IEmpleados/ListarEmpleadosResponse")]
        principal.ServiceReference1.Empleado[] ListarEmpleados();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpleadosChannel : principal.ServiceReference1.IEmpleados, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpleadosClient : System.ServiceModel.ClientBase<principal.ServiceReference1.IEmpleados>, principal.ServiceReference1.IEmpleados {
        
        public EmpleadosClient() {
        }
        
        public EmpleadosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpleadosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpleadosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpleadosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public principal.ServiceReference1.Empleado CrearEmpleado(string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado) {
            return base.Channel.CrearEmpleado(ApellidoEmpleado, CorreoEmpleado, CargoEmpleado, TelefonoEmpleado, AreaEmpleado);
        }
        
        public principal.ServiceReference1.Empleado ObtenerEmpleado(int CodEmpleado) {
            return base.Channel.ObtenerEmpleado(CodEmpleado);
        }
        
        public principal.ServiceReference1.Empleado ModificarEmpleado(int CodEmpleado, string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado) {
            return base.Channel.ModificarEmpleado(CodEmpleado, ApellidoEmpleado, CorreoEmpleado, CargoEmpleado, TelefonoEmpleado, AreaEmpleado);
        }
        
        public principal.ServiceReference1.Empleado EliminarEmpleado(int CodEmpleado) {
            return base.Channel.EliminarEmpleado(CodEmpleado);
        }
        
        public principal.ServiceReference1.Empleado[] ListarEmpleados() {
            return base.Channel.ListarEmpleados();
        }
    }
}
