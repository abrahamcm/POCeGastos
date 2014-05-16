﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5477
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.5477.
// 
#pragma warning disable 1591

namespace eGastosWS.WSeGastosPasteur {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="eGastos_PasteurSoap", Namespace="http://www.ultimus.com/eGastos_Pasteur")]
    public partial class eGastos_Pasteur : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetLaunchInformationOperationCompleted;
        
        private System.Threading.SendOrPostCallback LaunchIncidentOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetActiveTasksOperationCompleted;
        
        private System.Threading.SendOrPostCallback AbortIncidentOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTaskInformationOperationCompleted;
        
        private System.Threading.SendOrPostCallback CompleteStepOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReturnStepOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public eGastos_Pasteur() {
            this.Url = global::eGastosWS.Properties.Settings.Default.eGastosWS_WSeGastosPasteur_eGastos_Pasteur;
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
        public event GetLaunchInformationCompletedEventHandler GetLaunchInformationCompleted;
        
        /// <remarks/>
        public event LaunchIncidentCompletedEventHandler LaunchIncidentCompleted;
        
        /// <remarks/>
        public event GetActiveTasksCompletedEventHandler GetActiveTasksCompleted;
        
        /// <remarks/>
        public event AbortIncidentCompletedEventHandler AbortIncidentCompleted;
        
        /// <remarks/>
        public event GetTaskInformationCompletedEventHandler GetTaskInformationCompleted;
        
        /// <remarks/>
        public event CompleteStepCompletedEventHandler CompleteStepCompleted;
        
        /// <remarks/>
        public event ReturnStepCompletedEventHandler ReturnStepCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ultimus.com/eGastos_Pasteur/GetLaunchInformation", RequestNamespace="http://www.ultimus.com/eGastos_Pasteur", ResponseNamespace="http://www.ultimus.com/eGastos_Pasteur", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool GetLaunchInformation(string strUserName, out SchemaFile[] BeginSchema, out string strDefaultXML, out string strError) {
            object[] results = this.Invoke("GetLaunchInformation", new object[] {
                        strUserName});
            BeginSchema = ((SchemaFile[])(results[1]));
            strDefaultXML = ((string)(results[2]));
            strError = ((string)(results[3]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GetLaunchInformationAsync(string strUserName) {
            this.GetLaunchInformationAsync(strUserName, null);
        }
        
        /// <remarks/>
        public void GetLaunchInformationAsync(string strUserName, object userState) {
            if ((this.GetLaunchInformationOperationCompleted == null)) {
                this.GetLaunchInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLaunchInformationOperationCompleted);
            }
            this.InvokeAsync("GetLaunchInformation", new object[] {
                        strUserName}, this.GetLaunchInformationOperationCompleted, userState);
        }
        
        private void OnGetLaunchInformationOperationCompleted(object arg) {
            if ((this.GetLaunchInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLaunchInformationCompleted(this, new GetLaunchInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ultimus.com/eGastos_Pasteur/LaunchIncident", RequestNamespace="http://www.ultimus.com/eGastos_Pasteur", ResponseNamespace="http://www.ultimus.com/eGastos_Pasteur", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool LaunchIncident(string strUserName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML, out int nIncidentNo, out string strError) {
            object[] results = this.Invoke("LaunchIncident", new object[] {
                        strUserName,
                        strSummary,
                        strMemo,
                        bDisableAbort,
                        nPriority,
                        strXML,
                        bValidateXML});
            nIncidentNo = ((int)(results[1]));
            strError = ((string)(results[2]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LaunchIncidentAsync(string strUserName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML) {
            this.LaunchIncidentAsync(strUserName, strSummary, strMemo, bDisableAbort, nPriority, strXML, bValidateXML, null);
        }
        
        /// <remarks/>
        public void LaunchIncidentAsync(string strUserName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML, object userState) {
            if ((this.LaunchIncidentOperationCompleted == null)) {
                this.LaunchIncidentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLaunchIncidentOperationCompleted);
            }
            this.InvokeAsync("LaunchIncident", new object[] {
                        strUserName,
                        strSummary,
                        strMemo,
                        bDisableAbort,
                        nPriority,
                        strXML,
                        bValidateXML}, this.LaunchIncidentOperationCompleted, userState);
        }
        
        private void OnLaunchIncidentOperationCompleted(object arg) {
            if ((this.LaunchIncidentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LaunchIncidentCompleted(this, new LaunchIncidentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ultimus.com/eGastos_Pasteur/GetActiveTasks", RequestNamespace="http://www.ultimus.com/eGastos_Pasteur", ResponseNamespace="http://www.ultimus.com/eGastos_Pasteur", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool GetActiveTasks(string strUserName, out CTaskInfo[] taskList, out string strError) {
            object[] results = this.Invoke("GetActiveTasks", new object[] {
                        strUserName});
            taskList = ((CTaskInfo[])(results[1]));
            strError = ((string)(results[2]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GetActiveTasksAsync(string strUserName) {
            this.GetActiveTasksAsync(strUserName, null);
        }
        
        /// <remarks/>
        public void GetActiveTasksAsync(string strUserName, object userState) {
            if ((this.GetActiveTasksOperationCompleted == null)) {
                this.GetActiveTasksOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetActiveTasksOperationCompleted);
            }
            this.InvokeAsync("GetActiveTasks", new object[] {
                        strUserName}, this.GetActiveTasksOperationCompleted, userState);
        }
        
        private void OnGetActiveTasksOperationCompleted(object arg) {
            if ((this.GetActiveTasksCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetActiveTasksCompleted(this, new GetActiveTasksCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ultimus.com/eGastos_Pasteur/AbortIncident", RequestNamespace="http://www.ultimus.com/eGastos_Pasteur", ResponseNamespace="http://www.ultimus.com/eGastos_Pasteur", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AbortIncident(string strUserName, int nIncidentNumber, string strSummary, out string strError) {
            object[] results = this.Invoke("AbortIncident", new object[] {
                        strUserName,
                        nIncidentNumber,
                        strSummary});
            strError = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AbortIncidentAsync(string strUserName, int nIncidentNumber, string strSummary) {
            this.AbortIncidentAsync(strUserName, nIncidentNumber, strSummary, null);
        }
        
        /// <remarks/>
        public void AbortIncidentAsync(string strUserName, int nIncidentNumber, string strSummary, object userState) {
            if ((this.AbortIncidentOperationCompleted == null)) {
                this.AbortIncidentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAbortIncidentOperationCompleted);
            }
            this.InvokeAsync("AbortIncident", new object[] {
                        strUserName,
                        nIncidentNumber,
                        strSummary}, this.AbortIncidentOperationCompleted, userState);
        }
        
        private void OnAbortIncidentOperationCompleted(object arg) {
            if ((this.AbortIncidentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AbortIncidentCompleted(this, new AbortIncidentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ultimus.com/eGastos_Pasteur/GetTaskInformation", RequestNamespace="http://www.ultimus.com/eGastos_Pasteur", ResponseNamespace="http://www.ultimus.com/eGastos_Pasteur", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool GetTaskInformation(string strUserName, int nIncidentNumber, string strStepName, out SchemaFile[] TaskSchema, out string strTaskXML, out string strError) {
            object[] results = this.Invoke("GetTaskInformation", new object[] {
                        strUserName,
                        nIncidentNumber,
                        strStepName});
            TaskSchema = ((SchemaFile[])(results[1]));
            strTaskXML = ((string)(results[2]));
            strError = ((string)(results[3]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void GetTaskInformationAsync(string strUserName, int nIncidentNumber, string strStepName) {
            this.GetTaskInformationAsync(strUserName, nIncidentNumber, strStepName, null);
        }
        
        /// <remarks/>
        public void GetTaskInformationAsync(string strUserName, int nIncidentNumber, string strStepName, object userState) {
            if ((this.GetTaskInformationOperationCompleted == null)) {
                this.GetTaskInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTaskInformationOperationCompleted);
            }
            this.InvokeAsync("GetTaskInformation", new object[] {
                        strUserName,
                        nIncidentNumber,
                        strStepName}, this.GetTaskInformationOperationCompleted, userState);
        }
        
        private void OnGetTaskInformationOperationCompleted(object arg) {
            if ((this.GetTaskInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTaskInformationCompleted(this, new GetTaskInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ultimus.com/eGastos_Pasteur/CompleteStep", RequestNamespace="http://www.ultimus.com/eGastos_Pasteur", ResponseNamespace="http://www.ultimus.com/eGastos_Pasteur", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CompleteStep(string strUserName, ref int nIncidentNumber, string strStepName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML, out string strError) {
            object[] results = this.Invoke("CompleteStep", new object[] {
                        strUserName,
                        nIncidentNumber,
                        strStepName,
                        strSummary,
                        strMemo,
                        bDisableAbort,
                        nPriority,
                        strXML,
                        bValidateXML});
            nIncidentNumber = ((int)(results[1]));
            strError = ((string)(results[2]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CompleteStepAsync(string strUserName, int nIncidentNumber, string strStepName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML) {
            this.CompleteStepAsync(strUserName, nIncidentNumber, strStepName, strSummary, strMemo, bDisableAbort, nPriority, strXML, bValidateXML, null);
        }
        
        /// <remarks/>
        public void CompleteStepAsync(string strUserName, int nIncidentNumber, string strStepName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML, object userState) {
            if ((this.CompleteStepOperationCompleted == null)) {
                this.CompleteStepOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCompleteStepOperationCompleted);
            }
            this.InvokeAsync("CompleteStep", new object[] {
                        strUserName,
                        nIncidentNumber,
                        strStepName,
                        strSummary,
                        strMemo,
                        bDisableAbort,
                        nPriority,
                        strXML,
                        bValidateXML}, this.CompleteStepOperationCompleted, userState);
        }
        
        private void OnCompleteStepOperationCompleted(object arg) {
            if ((this.CompleteStepCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CompleteStepCompleted(this, new CompleteStepCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ultimus.com/eGastos_Pasteur/ReturnStep", RequestNamespace="http://www.ultimus.com/eGastos_Pasteur", ResponseNamespace="http://www.ultimus.com/eGastos_Pasteur", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ReturnStep(string strUserName, ref int nIncidentNumber, string strStepName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML, out string strError) {
            object[] results = this.Invoke("ReturnStep", new object[] {
                        strUserName,
                        nIncidentNumber,
                        strStepName,
                        strSummary,
                        strMemo,
                        bDisableAbort,
                        nPriority,
                        strXML,
                        bValidateXML});
            nIncidentNumber = ((int)(results[1]));
            strError = ((string)(results[2]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ReturnStepAsync(string strUserName, int nIncidentNumber, string strStepName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML) {
            this.ReturnStepAsync(strUserName, nIncidentNumber, strStepName, strSummary, strMemo, bDisableAbort, nPriority, strXML, bValidateXML, null);
        }
        
        /// <remarks/>
        public void ReturnStepAsync(string strUserName, int nIncidentNumber, string strStepName, string strSummary, string strMemo, bool bDisableAbort, int nPriority, string strXML, bool bValidateXML, object userState) {
            if ((this.ReturnStepOperationCompleted == null)) {
                this.ReturnStepOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReturnStepOperationCompleted);
            }
            this.InvokeAsync("ReturnStep", new object[] {
                        strUserName,
                        nIncidentNumber,
                        strStepName,
                        strSummary,
                        strMemo,
                        bDisableAbort,
                        nPriority,
                        strXML,
                        bValidateXML}, this.ReturnStepOperationCompleted, userState);
        }
        
        private void OnReturnStepOperationCompleted(object arg) {
            if ((this.ReturnStepCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReturnStepCompleted(this, new ReturnStepCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5476")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ultimus.com/eGastos_Pasteur")]
    public partial class SchemaFile {
        
        private string schemaFileNameField;
        
        private string schemaDataField;
        
        /// <remarks/>
        public string SchemaFileName {
            get {
                return this.schemaFileNameField;
            }
            set {
                this.schemaFileNameField = value;
            }
        }
        
        /// <remarks/>
        public string SchemaData {
            get {
                return this.schemaDataField;
            }
            set {
                this.schemaDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5476")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ultimus.com/eGastos_Pasteur")]
    public partial class CTaskInfo {
        
        private string m_strStepLabelField;
        
        private string m_strSummaryField;
        
        private int m_nIncidentNumField;
        
        /// <remarks/>
        public string m_strStepLabel {
            get {
                return this.m_strStepLabelField;
            }
            set {
                this.m_strStepLabelField = value;
            }
        }
        
        /// <remarks/>
        public string m_strSummary {
            get {
                return this.m_strSummaryField;
            }
            set {
                this.m_strSummaryField = value;
            }
        }
        
        /// <remarks/>
        public int m_nIncidentNum {
            get {
                return this.m_nIncidentNumField;
            }
            set {
                this.m_nIncidentNumField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    public delegate void GetLaunchInformationCompletedEventHandler(object sender, GetLaunchInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLaunchInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetLaunchInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public SchemaFile[] BeginSchema {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SchemaFile[])(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string strDefaultXML {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public string strError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    public delegate void LaunchIncidentCompletedEventHandler(object sender, LaunchIncidentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LaunchIncidentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LaunchIncidentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public int nIncidentNo {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string strError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    public delegate void GetActiveTasksCompletedEventHandler(object sender, GetActiveTasksCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetActiveTasksCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetActiveTasksCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public CTaskInfo[] taskList {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CTaskInfo[])(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string strError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    public delegate void AbortIncidentCompletedEventHandler(object sender, AbortIncidentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AbortIncidentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AbortIncidentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public string strError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    public delegate void GetTaskInformationCompletedEventHandler(object sender, GetTaskInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTaskInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTaskInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public SchemaFile[] TaskSchema {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SchemaFile[])(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string strTaskXML {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public string strError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[3]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    public delegate void CompleteStepCompletedEventHandler(object sender, CompleteStepCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CompleteStepCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CompleteStepCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public int nIncidentNumber {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string strError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    public delegate void ReturnStepCompletedEventHandler(object sender, ReturnStepCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReturnStepCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReturnStepCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public int nIncidentNumber {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string strError {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
}

#pragma warning restore 1591