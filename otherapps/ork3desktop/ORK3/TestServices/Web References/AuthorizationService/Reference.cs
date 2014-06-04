﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.261.
// 
#pragma warning disable 1591

namespace TestServices.AuthorizationService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AuthorizationServiceBinding", Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(AuthorizationsItemType))]
    public partial class AuthorizationService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AuthorizeOperationCompleted;
        
        private System.Threading.SendOrPostCallback XSiteAuthorizeOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddAuthorizationOperationCompleted;
        
        private System.Threading.SendOrPostCallback RemoveAuthorizationOperationCompleted;
        
        private System.Threading.SendOrPostCallback ResetPasswordOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAuthorizationsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AuthorizationService() {
            this.Url = global::TestServices.Properties.Settings.Default.TestServices_AuthorizationService_AuthorizationService;
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
        public event AuthorizeCompletedEventHandler AuthorizeCompleted;
        
        /// <remarks/>
        public event XSiteAuthorizeCompletedEventHandler XSiteAuthorizeCompleted;
        
        /// <remarks/>
        public event AddAuthorizationCompletedEventHandler AddAuthorizationCompleted;
        
        /// <remarks/>
        public event RemoveAuthorizationCompletedEventHandler RemoveAuthorizationCompleted;
        
        /// <remarks/>
        public event ResetPasswordCompletedEventHandler ResetPasswordCompleted;
        
        /// <remarks/>
        public event GetAuthorizationsCompletedEventHandler GetAuthorizationsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php/Authorize", RequestNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl", ResponseNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public AuthorizeResponse Authorize(AuthorizeRequest AuthorizeRequest) {
            object[] results = this.Invoke("Authorize", new object[] {
                        AuthorizeRequest});
            return ((AuthorizeResponse)(results[0]));
        }
        
        /// <remarks/>
        public void AuthorizeAsync(AuthorizeRequest AuthorizeRequest) {
            this.AuthorizeAsync(AuthorizeRequest, null);
        }
        
        /// <remarks/>
        public void AuthorizeAsync(AuthorizeRequest AuthorizeRequest, object userState) {
            if ((this.AuthorizeOperationCompleted == null)) {
                this.AuthorizeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAuthorizeOperationCompleted);
            }
            this.InvokeAsync("Authorize", new object[] {
                        AuthorizeRequest}, this.AuthorizeOperationCompleted, userState);
        }
        
        private void OnAuthorizeOperationCompleted(object arg) {
            if ((this.AuthorizeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AuthorizeCompleted(this, new AuthorizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php/XSiteAuthorize", RequestNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl", ResponseNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public XSiteAuthorizeResponse XSiteAuthorize(XSiteAuthorizeRequest XSiteAuthorizeRequest) {
            object[] results = this.Invoke("XSiteAuthorize", new object[] {
                        XSiteAuthorizeRequest});
            return ((XSiteAuthorizeResponse)(results[0]));
        }
        
        /// <remarks/>
        public void XSiteAuthorizeAsync(XSiteAuthorizeRequest XSiteAuthorizeRequest) {
            this.XSiteAuthorizeAsync(XSiteAuthorizeRequest, null);
        }
        
        /// <remarks/>
        public void XSiteAuthorizeAsync(XSiteAuthorizeRequest XSiteAuthorizeRequest, object userState) {
            if ((this.XSiteAuthorizeOperationCompleted == null)) {
                this.XSiteAuthorizeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnXSiteAuthorizeOperationCompleted);
            }
            this.InvokeAsync("XSiteAuthorize", new object[] {
                        XSiteAuthorizeRequest}, this.XSiteAuthorizeOperationCompleted, userState);
        }
        
        private void OnXSiteAuthorizeOperationCompleted(object arg) {
            if ((this.XSiteAuthorizeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.XSiteAuthorizeCompleted(this, new XSiteAuthorizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php/AddAuthorization", RequestNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl", ResponseNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public StatusType AddAuthorization(AddAuthorizationRequest AddAuthorizationRequest) {
            object[] results = this.Invoke("AddAuthorization", new object[] {
                        AddAuthorizationRequest});
            return ((StatusType)(results[0]));
        }
        
        /// <remarks/>
        public void AddAuthorizationAsync(AddAuthorizationRequest AddAuthorizationRequest) {
            this.AddAuthorizationAsync(AddAuthorizationRequest, null);
        }
        
        /// <remarks/>
        public void AddAuthorizationAsync(AddAuthorizationRequest AddAuthorizationRequest, object userState) {
            if ((this.AddAuthorizationOperationCompleted == null)) {
                this.AddAuthorizationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddAuthorizationOperationCompleted);
            }
            this.InvokeAsync("AddAuthorization", new object[] {
                        AddAuthorizationRequest}, this.AddAuthorizationOperationCompleted, userState);
        }
        
        private void OnAddAuthorizationOperationCompleted(object arg) {
            if ((this.AddAuthorizationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddAuthorizationCompleted(this, new AddAuthorizationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php/RemoveAuthorization", RequestNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl", ResponseNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public StatusType RemoveAuthorization(RemoveAuthorizationRequest RemoveAuthorizationRequest) {
            object[] results = this.Invoke("RemoveAuthorization", new object[] {
                        RemoveAuthorizationRequest});
            return ((StatusType)(results[0]));
        }
        
        /// <remarks/>
        public void RemoveAuthorizationAsync(RemoveAuthorizationRequest RemoveAuthorizationRequest) {
            this.RemoveAuthorizationAsync(RemoveAuthorizationRequest, null);
        }
        
        /// <remarks/>
        public void RemoveAuthorizationAsync(RemoveAuthorizationRequest RemoveAuthorizationRequest, object userState) {
            if ((this.RemoveAuthorizationOperationCompleted == null)) {
                this.RemoveAuthorizationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRemoveAuthorizationOperationCompleted);
            }
            this.InvokeAsync("RemoveAuthorization", new object[] {
                        RemoveAuthorizationRequest}, this.RemoveAuthorizationOperationCompleted, userState);
        }
        
        private void OnRemoveAuthorizationOperationCompleted(object arg) {
            if ((this.RemoveAuthorizationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RemoveAuthorizationCompleted(this, new RemoveAuthorizationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php/ResetPassword", RequestNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl", ResponseNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public StatusType ResetPassword(ResetPasswordRequest ResetPasswordRequest) {
            object[] results = this.Invoke("ResetPassword", new object[] {
                        ResetPasswordRequest});
            return ((StatusType)(results[0]));
        }
        
        /// <remarks/>
        public void ResetPasswordAsync(ResetPasswordRequest ResetPasswordRequest) {
            this.ResetPasswordAsync(ResetPasswordRequest, null);
        }
        
        /// <remarks/>
        public void ResetPasswordAsync(ResetPasswordRequest ResetPasswordRequest, object userState) {
            if ((this.ResetPasswordOperationCompleted == null)) {
                this.ResetPasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnResetPasswordOperationCompleted);
            }
            this.InvokeAsync("ResetPassword", new object[] {
                        ResetPasswordRequest}, this.ResetPasswordOperationCompleted, userState);
        }
        
        private void OnResetPasswordOperationCompleted(object arg) {
            if ((this.ResetPasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ResetPasswordCompleted(this, new ResetPasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php/GetAuthorizations", RequestNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl", ResponseNamespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
            "php?wsdl")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public GetAuthorizationsResponse GetAuthorizations(GetAuthorizationsRequest GetAuthorizationsRequest) {
            object[] results = this.Invoke("GetAuthorizations", new object[] {
                        GetAuthorizationsRequest});
            return ((GetAuthorizationsResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetAuthorizationsAsync(GetAuthorizationsRequest GetAuthorizationsRequest) {
            this.GetAuthorizationsAsync(GetAuthorizationsRequest, null);
        }
        
        /// <remarks/>
        public void GetAuthorizationsAsync(GetAuthorizationsRequest GetAuthorizationsRequest, object userState) {
            if ((this.GetAuthorizationsOperationCompleted == null)) {
                this.GetAuthorizationsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAuthorizationsOperationCompleted);
            }
            this.InvokeAsync("GetAuthorizations", new object[] {
                        GetAuthorizationsRequest}, this.GetAuthorizationsOperationCompleted, userState);
        }
        
        private void OnGetAuthorizationsOperationCompleted(object arg) {
            if ((this.GetAuthorizationsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAuthorizationsCompleted(this, new GetAuthorizationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class AuthorizeRequest {
        
        private string userNameField;
        
        private string passwordField;
        
        private string tokenField;
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class AuthorizationsItemType {
        
        private int authorizationIdField;
        
        private string typeField;
        
        private int idField;
        
        private string roleField;
        
        private string detailField;
        
        /// <remarks/>
        public int AuthorizationId {
            get {
                return this.authorizationIdField;
            }
            set {
                this.authorizationIdField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public string Detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class GetAuthorizationsResponse {
        
        private StatusType statusField;
        
        private AuthorizationsItemType[] authorizationsField;
        
        /// <remarks/>
        public StatusType Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public AuthorizationsItemType[] Authorizations {
            get {
                return this.authorizationsField;
            }
            set {
                this.authorizationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class StatusType {
        
        private int statusField;
        
        private string errorField;
        
        private string detailField;
        
        /// <remarks/>
        public int Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        public string Detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class GetAuthorizationsRequest {
        
        private string tokenField;
        
        private int mundaneIdField;
        
        /// <remarks/>
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
        
        /// <remarks/>
        public int MundaneId {
            get {
                return this.mundaneIdField;
            }
            set {
                this.mundaneIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class ResetPasswordRequest {
        
        private string userNameField;
        
        private string emailField;
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class RemoveAuthorizationRequest {
        
        private string tokenField;
        
        private int authorizationIdField;
        
        /// <remarks/>
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
        
        /// <remarks/>
        public int AuthorizationId {
            get {
                return this.authorizationIdField;
            }
            set {
                this.authorizationIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class AddAuthorizationRequest {
        
        private string tokenField;
        
        private int mundaneIdField;
        
        private string typeField;
        
        private string roleField;
        
        private int idField;
        
        /// <remarks/>
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
        
        /// <remarks/>
        public int MundaneId {
            get {
                return this.mundaneIdField;
            }
            set {
                this.mundaneIdField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class XSiteAuthorizeResponse {
        
        private StatusType statusField;
        
        private string tokenField;
        
        /// <remarks/>
        public StatusType Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class XSiteAuthorizeRequest {
        
        private string userNameField;
        
        private string passwordField;
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.amtgard-wl.com/ork3/dev/orkservice/Authorization/AuthorizationService." +
        "php?wsdl")]
    public partial class AuthorizeResponse {
        
        private StatusType statusField;
        
        private string tokenField;
        
        private int userIdField;
        
        private System.DateTime timeoutField;
        
        /// <remarks/>
        public StatusType Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
        
        /// <remarks/>
        public int UserId {
            get {
                return this.userIdField;
            }
            set {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AuthorizeCompletedEventHandler(object sender, AuthorizeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuthorizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AuthorizeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AuthorizeResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AuthorizeResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void XSiteAuthorizeCompletedEventHandler(object sender, XSiteAuthorizeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class XSiteAuthorizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal XSiteAuthorizeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public XSiteAuthorizeResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((XSiteAuthorizeResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void AddAuthorizationCompletedEventHandler(object sender, AddAuthorizationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddAuthorizationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddAuthorizationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StatusType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StatusType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void RemoveAuthorizationCompletedEventHandler(object sender, RemoveAuthorizationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RemoveAuthorizationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RemoveAuthorizationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StatusType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StatusType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ResetPasswordCompletedEventHandler(object sender, ResetPasswordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResetPasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ResetPasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StatusType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StatusType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetAuthorizationsCompletedEventHandler(object sender, GetAuthorizationsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAuthorizationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAuthorizationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GetAuthorizationsResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GetAuthorizationsResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591