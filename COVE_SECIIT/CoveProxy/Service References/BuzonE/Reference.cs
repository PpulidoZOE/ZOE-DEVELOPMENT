﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoveProxy.BuzonE {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timbrado.buzone.com.mx/TimbradoCFD/Schema")]
    public partial class TimbradoError : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timbrado.buzone.com.mx/TimbradoCFD/Schema")]
    public partial class TimbradoResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object xmlCFDTimbradoField;
        
        private string uUIDField;
        
        private string selloSATField;
        
        private string versionField;
        
        private string noCertificadoSATField;
        
        private string selloCFDField;
        
        private System.DateTime fechaTimbradoField;
        
        private bool fechaTimbradoFieldSpecified;
        
        private string rfcProvCertifField;
        
        private string leyendaField;
        
        private TimbradoDatosAdicionales datosAdicionalesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public object xmlCFDTimbrado {
            get {
                return this.xmlCFDTimbradoField;
            }
            set {
                this.xmlCFDTimbradoField = value;
                this.RaisePropertyChanged("xmlCFDTimbrado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
                this.RaisePropertyChanged("UUID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string selloSAT {
            get {
                return this.selloSATField;
            }
            set {
                this.selloSATField = value;
                this.RaisePropertyChanged("selloSAT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string noCertificadoSAT {
            get {
                return this.noCertificadoSATField;
            }
            set {
                this.noCertificadoSATField = value;
                this.RaisePropertyChanged("noCertificadoSAT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string selloCFD {
            get {
                return this.selloCFDField;
            }
            set {
                this.selloCFDField = value;
                this.RaisePropertyChanged("selloCFD");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime fechaTimbrado {
            get {
                return this.fechaTimbradoField;
            }
            set {
                this.fechaTimbradoField = value;
                this.RaisePropertyChanged("fechaTimbrado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaTimbradoSpecified {
            get {
                return this.fechaTimbradoFieldSpecified;
            }
            set {
                this.fechaTimbradoFieldSpecified = value;
                this.RaisePropertyChanged("fechaTimbradoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string rfcProvCertif {
            get {
                return this.rfcProvCertifField;
            }
            set {
                this.rfcProvCertifField = value;
                this.RaisePropertyChanged("rfcProvCertif");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string leyenda {
            get {
                return this.leyendaField;
            }
            set {
                this.leyendaField = value;
                this.RaisePropertyChanged("leyenda");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public TimbradoDatosAdicionales datosAdicionales {
            get {
                return this.datosAdicionalesField;
            }
            set {
                this.datosAdicionalesField = value;
                this.RaisePropertyChanged("datosAdicionales");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timbrado.buzone.com.mx/TimbradoCFD/Schema")]
    public partial class TimbradoDatosAdicionales : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string batchIdField;
        
        private string statusField;
        
        private error[] errorListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string batchId {
            get {
                return this.batchIdField;
            }
            set {
                this.batchIdField = value;
                this.RaisePropertyChanged("batchId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public error[] errorList {
            get {
                return this.errorListField;
            }
            set {
                this.errorListField = value;
                this.RaisePropertyChanged("errorList");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timbrado.buzone.com.mx/TimbradoCFD/Schema")]
    public partial class error : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string messageField;
        
        private string detailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
                this.RaisePropertyChanged("detail");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://timbrado.buzone.com.mx/TimbradoCFD/Schema")]
    public partial class TimbradoRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string usuarioField;
        
        private string passwordField;
        
        private object xmlCFDField;
        
        private string tituloField;
        
        private string conectorField;
        
        private string fileTypeField;
        
        private int returnCFDTimbradoField;
        
        private string comentarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
                this.RaisePropertyChanged("usuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public object xmlCFD {
            get {
                return this.xmlCFDField;
            }
            set {
                this.xmlCFDField = value;
                this.RaisePropertyChanged("xmlCFD");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string titulo {
            get {
                return this.tituloField;
            }
            set {
                this.tituloField = value;
                this.RaisePropertyChanged("titulo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string conector {
            get {
                return this.conectorField;
            }
            set {
                this.conectorField = value;
                this.RaisePropertyChanged("conector");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string fileType {
            get {
                return this.fileTypeField;
            }
            set {
                this.fileTypeField = value;
                this.RaisePropertyChanged("fileType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int returnCFDTimbrado {
            get {
                return this.returnCFDTimbradoField;
            }
            set {
                this.returnCFDTimbradoField = value;
                this.RaisePropertyChanged("returnCFDTimbrado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string comentario {
            get {
                return this.comentarioField;
            }
            set {
                this.comentarioField = value;
                this.RaisePropertyChanged("comentario");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://timbrado.buzone.com.mx/TimbradoCFD", ConfigurationName="BuzonE.TimbradoCFD")]
    public interface TimbradoCFD {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que la operación timbradoCFD no es RPC ni está encapsulada en un documento.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(CoveProxy.BuzonE.TimbradoError), Action="", Name="fault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        CoveProxy.BuzonE.timbradoCFDResponse timbradoCFD(CoveProxy.BuzonE.timbradoCFDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<CoveProxy.BuzonE.timbradoCFDResponse> timbradoCFDAsync(CoveProxy.BuzonE.timbradoCFDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class timbradoCFDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://timbrado.buzone.com.mx/TimbradoCFD", Order=0)]
        public CoveProxy.BuzonE.TimbradoRequest in0;
        
        public timbradoCFDRequest() {
        }
        
        public timbradoCFDRequest(CoveProxy.BuzonE.TimbradoRequest in0) {
            this.in0 = in0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class timbradoCFDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://timbrado.buzone.com.mx/TimbradoCFD", Order=0)]
        public CoveProxy.BuzonE.TimbradoResponse timbradoCFDReturn;
        
        public timbradoCFDResponse() {
        }
        
        public timbradoCFDResponse(CoveProxy.BuzonE.TimbradoResponse timbradoCFDReturn) {
            this.timbradoCFDReturn = timbradoCFDReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TimbradoCFDChannel : CoveProxy.BuzonE.TimbradoCFD, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TimbradoCFDClient : System.ServiceModel.ClientBase<CoveProxy.BuzonE.TimbradoCFD>, CoveProxy.BuzonE.TimbradoCFD {
        
        public TimbradoCFDClient() {
        }
        
        public TimbradoCFDClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TimbradoCFDClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimbradoCFDClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TimbradoCFDClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CoveProxy.BuzonE.timbradoCFDResponse CoveProxy.BuzonE.TimbradoCFD.timbradoCFD(CoveProxy.BuzonE.timbradoCFDRequest request) {
            return base.Channel.timbradoCFD(request);
        }
        
        public CoveProxy.BuzonE.TimbradoResponse timbradoCFD(CoveProxy.BuzonE.TimbradoRequest in0) {
            CoveProxy.BuzonE.timbradoCFDRequest inValue = new CoveProxy.BuzonE.timbradoCFDRequest();
            inValue.in0 = in0;
            CoveProxy.BuzonE.timbradoCFDResponse retVal = ((CoveProxy.BuzonE.TimbradoCFD)(this)).timbradoCFD(inValue);
            return retVal.timbradoCFDReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CoveProxy.BuzonE.timbradoCFDResponse> CoveProxy.BuzonE.TimbradoCFD.timbradoCFDAsync(CoveProxy.BuzonE.timbradoCFDRequest request) {
            return base.Channel.timbradoCFDAsync(request);
        }
        
        public System.Threading.Tasks.Task<CoveProxy.BuzonE.timbradoCFDResponse> timbradoCFDAsync(CoveProxy.BuzonE.TimbradoRequest in0) {
            CoveProxy.BuzonE.timbradoCFDRequest inValue = new CoveProxy.BuzonE.timbradoCFDRequest();
            inValue.in0 = in0;
            return ((CoveProxy.BuzonE.TimbradoCFD)(this)).timbradoCFDAsync(inValue);
        }
    }
}
