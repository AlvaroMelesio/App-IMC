//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace App_IMC.Azure {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GuardarOperationCompleted;
        
        private System.Threading.SendOrPostCallback BusquedaFolioOperationCompleted;
        
        private System.Threading.SendOrPostCallback BusquedaOperationCompleted;
        
        private System.Threading.SendOrPostCallback GuardarIMCOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarIMCOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = "https://alvaromelesio.azurewebsites.net/WebService1.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GuardarCompletedEventHandler GuardarCompleted;
        
        /// <remarks/>
        public event BusquedaFolioCompletedEventHandler BusquedaFolioCompleted;
        
        /// <remarks/>
        public event BusquedaCompletedEventHandler BusquedaCompleted;
        
        /// <remarks/>
        public event GuardarIMCCompletedEventHandler GuardarIMCCompleted;
        
        /// <remarks/>
        public event BuscarIMCCompletedEventHandler BuscarIMCCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Guardar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Guardar(string Nombre, string Domicilio, string Correo, int Edad, double Saldo) {
            object[] results = this.Invoke("Guardar", new object[] {
                        Nombre,
                        Domicilio,
                        Correo,
                        Edad,
                        Saldo});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GuardarAsync(string Nombre, string Domicilio, string Correo, int Edad, double Saldo) {
            this.GuardarAsync(Nombre, Domicilio, Correo, Edad, Saldo, null);
        }
        
        /// <remarks/>
        public void GuardarAsync(string Nombre, string Domicilio, string Correo, int Edad, double Saldo, object userState) {
            if ((this.GuardarOperationCompleted == null)) {
                this.GuardarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGuardarOperationCompleted);
            }
            this.InvokeAsync("Guardar", new object[] {
                        Nombre,
                        Domicilio,
                        Correo,
                        Edad,
                        Saldo}, this.GuardarOperationCompleted, userState);
        }
        
        private void OnGuardarOperationCompleted(object arg) {
            if ((this.GuardarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GuardarCompleted(this, new GuardarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BusquedaFolio", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet BusquedaFolio(int Folio) {
            object[] results = this.Invoke("BusquedaFolio", new object[] {
                        Folio});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void BusquedaFolioAsync(int Folio) {
            this.BusquedaFolioAsync(Folio, null);
        }
        
        /// <remarks/>
        public void BusquedaFolioAsync(int Folio, object userState) {
            if ((this.BusquedaFolioOperationCompleted == null)) {
                this.BusquedaFolioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBusquedaFolioOperationCompleted);
            }
            this.InvokeAsync("BusquedaFolio", new object[] {
                        Folio}, this.BusquedaFolioOperationCompleted, userState);
        }
        
        private void OnBusquedaFolioOperationCompleted(object arg) {
            if ((this.BusquedaFolioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BusquedaFolioCompleted(this, new BusquedaFolioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Busqueda", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Busqueda() {
            object[] results = this.Invoke("Busqueda", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void BusquedaAsync() {
            this.BusquedaAsync(null);
        }
        
        /// <remarks/>
        public void BusquedaAsync(object userState) {
            if ((this.BusquedaOperationCompleted == null)) {
                this.BusquedaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBusquedaOperationCompleted);
            }
            this.InvokeAsync("Busqueda", new object[0], this.BusquedaOperationCompleted, userState);
        }
        
        private void OnBusquedaOperationCompleted(object arg) {
            if ((this.BusquedaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BusquedaCompleted(this, new BusquedaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GuardarIMC", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool GuardarIMC(string Nombre, double Peso, double Estatura, double Resultado, string Estado) {
            object[] results = this.Invoke("GuardarIMC", new object[] {
                        Nombre,
                        Peso,
                        Estatura,
                        Resultado,
                        Estado});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GuardarIMCAsync(string Nombre, double Peso, double Estatura, double Resultado, string Estado) {
            this.GuardarIMCAsync(Nombre, Peso, Estatura, Resultado, Estado, null);
        }
        
        /// <remarks/>
        public void GuardarIMCAsync(string Nombre, double Peso, double Estatura, double Resultado, string Estado, object userState) {
            if ((this.GuardarIMCOperationCompleted == null)) {
                this.GuardarIMCOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGuardarIMCOperationCompleted);
            }
            this.InvokeAsync("GuardarIMC", new object[] {
                        Nombre,
                        Peso,
                        Estatura,
                        Resultado,
                        Estado}, this.GuardarIMCOperationCompleted, userState);
        }
        
        private void OnGuardarIMCOperationCompleted(object arg) {
            if ((this.GuardarIMCCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GuardarIMCCompleted(this, new GuardarIMCCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarIMC", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet BuscarIMC(string Nombre, int Dia, string Mes) {
            object[] results = this.Invoke("BuscarIMC", new object[] {
                        Nombre,
                        Dia,
                        Mes});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarIMCAsync(string Nombre, int Dia, string Mes) {
            this.BuscarIMCAsync(Nombre, Dia, Mes, null);
        }
        
        /// <remarks/>
        public void BuscarIMCAsync(string Nombre, int Dia, string Mes, object userState) {
            if ((this.BuscarIMCOperationCompleted == null)) {
                this.BuscarIMCOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarIMCOperationCompleted);
            }
            this.InvokeAsync("BuscarIMC", new object[] {
                        Nombre,
                        Dia,
                        Mes}, this.BuscarIMCOperationCompleted, userState);
        }
        
        private void OnBuscarIMCOperationCompleted(object arg) {
            if ((this.BuscarIMCCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarIMCCompleted(this, new BuscarIMCCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GuardarCompletedEventHandler(object sender, GuardarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GuardarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GuardarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void BusquedaFolioCompletedEventHandler(object sender, BusquedaFolioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BusquedaFolioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BusquedaFolioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void BusquedaCompletedEventHandler(object sender, BusquedaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BusquedaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BusquedaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GuardarIMCCompletedEventHandler(object sender, GuardarIMCCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GuardarIMCCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GuardarIMCCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void BuscarIMCCompletedEventHandler(object sender, BuscarIMCCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarIMCCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarIMCCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591