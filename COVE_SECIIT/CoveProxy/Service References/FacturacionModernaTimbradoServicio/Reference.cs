﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoveProxy.FacturacionModernaTimbradoServicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://t1demo.facturacionmoderna.com/timbrado/soap", ConfigurationName="FacturacionModernaTimbradoServicio.Timbrado_ManagerPort")]
    public interface Timbrado_ManagerPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://t1demo.facturacionmoderna.com/timbrado/soap#consultarSaldo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        CoveProxy.FacturacionModernaTimbradoServicio.consultarSaldoResponse consultarSaldo(CoveProxy.FacturacionModernaTimbradoServicio.consultarSaldoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://t1demo.facturacionmoderna.com/timbrado/soap#validarCFDI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        CoveProxy.FacturacionModernaTimbradoServicio.validarCFDIResponse validarCFDI(CoveProxy.FacturacionModernaTimbradoServicio.validarCFDIRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://t1demo.facturacionmoderna.com/timbrado/soap#verificarCFDI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        CoveProxy.FacturacionModernaTimbradoServicio.verificarCFDIResponse verificarCFDI(CoveProxy.FacturacionModernaTimbradoServicio.verificarCFDIRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://t1demo.facturacionmoderna.com/timbrado/soap#requestTimbrarCFDI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        CoveProxy.FacturacionModernaTimbradoServicio.requestTimbrarCFDIResponse requestTimbrarCFDI(CoveProxy.FacturacionModernaTimbradoServicio.requestTimbrarCFDIRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://t1demo.facturacionmoderna.com/timbrado/soap#requestCancelarCFDI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        CoveProxy.FacturacionModernaTimbradoServicio.requestCancelarCFDIResponse requestCancelarCFDI(CoveProxy.FacturacionModernaTimbradoServicio.requestCancelarCFDIRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://t1demo.facturacionmoderna.com/timbrado/soap#activarCancelacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        CoveProxy.FacturacionModernaTimbradoServicio.activarCancelacionResponse activarCancelacion(CoveProxy.FacturacionModernaTimbradoServicio.activarCancelacionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarSaldo", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class consultarSaldoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object request;
        
        public consultarSaldoRequest() {
        }
        
        public consultarSaldoRequest(object request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultarSaldoResponse", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class consultarSaldoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object @return;
        
        public consultarSaldoResponse() {
        }
        
        public consultarSaldoResponse(object @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarCFDI", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class validarCFDIRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object request;
        
        public validarCFDIRequest() {
        }
        
        public validarCFDIRequest(object request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarCFDIResponse", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class validarCFDIResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object @return;
        
        public validarCFDIResponse() {
        }
        
        public validarCFDIResponse(object @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificarCFDI", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class verificarCFDIRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object request;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public object @internal;
        
        public verificarCFDIRequest() {
        }
        
        public verificarCFDIRequest(object request, object @internal) {
            this.request = request;
            this.@internal = @internal;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificarCFDIResponse", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class verificarCFDIResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object @return;
        
        public verificarCFDIResponse() {
        }
        
        public verificarCFDIResponse(object @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="requestTimbrarCFDI", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class requestTimbrarCFDIRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object request;
        
        public requestTimbrarCFDIRequest() {
        }
        
        public requestTimbrarCFDIRequest(object request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="requestTimbrarCFDIResponse", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class requestTimbrarCFDIResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object @return;
        
        public requestTimbrarCFDIResponse() {
        }
        
        public requestTimbrarCFDIResponse(object @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="requestCancelarCFDI", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class requestCancelarCFDIRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object request;
        
        public requestCancelarCFDIRequest() {
        }
        
        public requestCancelarCFDIRequest(object request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="requestCancelarCFDIResponse", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class requestCancelarCFDIResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object @return;
        
        public requestCancelarCFDIResponse() {
        }
        
        public requestCancelarCFDIResponse(object @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="activarCancelacion", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class activarCancelacionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object request;
        
        public activarCancelacionRequest() {
        }
        
        public activarCancelacionRequest(object request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="activarCancelacionResponse", WrapperNamespace="https://t1demo.facturacionmoderna.com/timbrado/soap", IsWrapped=true)]
    public partial class activarCancelacionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object @return;
        
        public activarCancelacionResponse() {
        }
        
        public activarCancelacionResponse(object @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Timbrado_ManagerPortChannel : CoveProxy.FacturacionModernaTimbradoServicio.Timbrado_ManagerPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Timbrado_ManagerPortClient : System.ServiceModel.ClientBase<CoveProxy.FacturacionModernaTimbradoServicio.Timbrado_ManagerPort>, CoveProxy.FacturacionModernaTimbradoServicio.Timbrado_ManagerPort {
        
        public Timbrado_ManagerPortClient() {
        }
        
        public Timbrado_ManagerPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Timbrado_ManagerPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Timbrado_ManagerPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Timbrado_ManagerPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CoveProxy.FacturacionModernaTimbradoServicio.consultarSaldoResponse consultarSaldo(CoveProxy.FacturacionModernaTimbradoServicio.consultarSaldoRequest request) {
            return base.Channel.consultarSaldo(request);
        }
        
        public CoveProxy.FacturacionModernaTimbradoServicio.validarCFDIResponse validarCFDI(CoveProxy.FacturacionModernaTimbradoServicio.validarCFDIRequest request) {
            return base.Channel.validarCFDI(request);
        }
        
        public CoveProxy.FacturacionModernaTimbradoServicio.verificarCFDIResponse verificarCFDI(CoveProxy.FacturacionModernaTimbradoServicio.verificarCFDIRequest request) {
            return base.Channel.verificarCFDI(request);
        }
        
        public CoveProxy.FacturacionModernaTimbradoServicio.requestTimbrarCFDIResponse requestTimbrarCFDI(CoveProxy.FacturacionModernaTimbradoServicio.requestTimbrarCFDIRequest request) {
            return base.Channel.requestTimbrarCFDI(request);
        }
        
        public CoveProxy.FacturacionModernaTimbradoServicio.requestCancelarCFDIResponse requestCancelarCFDI(CoveProxy.FacturacionModernaTimbradoServicio.requestCancelarCFDIRequest request) {
            return base.Channel.requestCancelarCFDI(request);
        }
        
        public CoveProxy.FacturacionModernaTimbradoServicio.activarCancelacionResponse activarCancelacion(CoveProxy.FacturacionModernaTimbradoServicio.activarCancelacionRequest request) {
            return base.Channel.activarCancelacion(request);
        }
    }
}
