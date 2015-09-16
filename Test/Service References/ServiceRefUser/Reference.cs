﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.ServiceRefUser {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRefUser.IEmpleados")]
    public interface IEmpleados {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/CrearEmpleado", ReplyAction="http://tempuri.org/IEmpleados/CrearEmpleadoResponse")]
        principal.ServiceRefUser.Empleado CrearEmpleado(string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/ObtenerEmpleado", ReplyAction="http://tempuri.org/IEmpleados/ObtenerEmpleadoResponse")]
        principal.ServiceRefUser.Empleado ObtenerEmpleado(int CodEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/ModificarEmpleado", ReplyAction="http://tempuri.org/IEmpleados/ModificarEmpleadoResponse")]
        principal.ServiceRefUser.Empleado ModificarEmpleado(int CodEmpleado, string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/EliminarEmpleado", ReplyAction="http://tempuri.org/IEmpleados/EliminarEmpleadoResponse")]
        principal.ServiceRefUser.Empleado EliminarEmpleado(int CodEmpleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpleados/ListarEmpleados", ReplyAction="http://tempuri.org/IEmpleados/ListarEmpleadosResponse")]
        principal.ServiceRefUser.Empleado[] ListarEmpleados();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpleadosChannel : Test.ServiceRefUser.IEmpleados, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpleadosClient : System.ServiceModel.ClientBase<Test.ServiceRefUser.IEmpleados>, Test.ServiceRefUser.IEmpleados {
        
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
        
        public principal.ServiceRefUser.Empleado CrearEmpleado(string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado) {
            return base.Channel.CrearEmpleado(ApellidoEmpleado, CorreoEmpleado, CargoEmpleado, TelefonoEmpleado, AreaEmpleado);
        }
        
        public principal.ServiceRefUser.Empleado ObtenerEmpleado(int CodEmpleado) {
            return base.Channel.ObtenerEmpleado(CodEmpleado);
        }
        
        public principal.ServiceRefUser.Empleado ModificarEmpleado(int CodEmpleado, string ApellidoEmpleado, string CorreoEmpleado, string CargoEmpleado, string TelefonoEmpleado, string AreaEmpleado) {
            return base.Channel.ModificarEmpleado(CodEmpleado, ApellidoEmpleado, CorreoEmpleado, CargoEmpleado, TelefonoEmpleado, AreaEmpleado);
        }
        
        public principal.ServiceRefUser.Empleado EliminarEmpleado(int CodEmpleado) {
            return base.Channel.EliminarEmpleado(CodEmpleado);
        }
        
        public principal.ServiceRefUser.Empleado[] ListarEmpleados() {
            return base.Channel.ListarEmpleados();
        }
    }
}