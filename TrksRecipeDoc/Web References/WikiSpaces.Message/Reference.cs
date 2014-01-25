﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace TrksRecipeDoc.WikiSpaces.Message {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MessageBinding", Namespace="urn:Message")]
    public partial class MessageService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback listTopicsOperationCompleted;
        
        private System.Threading.SendOrPostCallback listMessagesInTopicOperationCompleted;
        
        private System.Threading.SendOrPostCallback createTopicOperationCompleted;
        
        private System.Threading.SendOrPostCallback createReplyOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteMessageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MessageService() {
            this.Url = global::TrksRecipeDoc.Properties.Settings.Default.TrksRecipeDoc_WikiSpaces_Message_MessageService;
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
        public event listTopicsCompletedEventHandler listTopicsCompleted;
        
        /// <remarks/>
        public event listMessagesInTopicCompletedEventHandler listMessagesInTopicCompleted;
        
        /// <remarks/>
        public event createTopicCompletedEventHandler createTopicCompleted;
        
        /// <remarks/>
        public event createReplyCompletedEventHandler createReplyCompleted;
        
        /// <remarks/>
        public event deleteMessageCompletedEventHandler deleteMessageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:Message#MessageSOAPApi#listTopics", RequestNamespace="urn:Message", ResponseNamespace="urn:Message")]
        [return: System.Xml.Serialization.SoapElementAttribute("messageList")]
        public MessageStruct[] listTopics(string session, int pageId) {
            object[] results = this.Invoke("listTopics", new object[] {
                        session,
                        pageId});
            return ((MessageStruct[])(results[0]));
        }
        
        /// <remarks/>
        public void listTopicsAsync(string session, int pageId) {
            this.listTopicsAsync(session, pageId, null);
        }
        
        /// <remarks/>
        public void listTopicsAsync(string session, int pageId, object userState) {
            if ((this.listTopicsOperationCompleted == null)) {
                this.listTopicsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistTopicsOperationCompleted);
            }
            this.InvokeAsync("listTopics", new object[] {
                        session,
                        pageId}, this.listTopicsOperationCompleted, userState);
        }
        
        private void OnlistTopicsOperationCompleted(object arg) {
            if ((this.listTopicsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listTopicsCompleted(this, new listTopicsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:Message#MessageSOAPApi#listMessagesInTopic", RequestNamespace="urn:Message", ResponseNamespace="urn:Message")]
        [return: System.Xml.Serialization.SoapElementAttribute("messageList")]
        public MessageStruct[] listMessagesInTopic(string session, int topicId) {
            object[] results = this.Invoke("listMessagesInTopic", new object[] {
                        session,
                        topicId});
            return ((MessageStruct[])(results[0]));
        }
        
        /// <remarks/>
        public void listMessagesInTopicAsync(string session, int topicId) {
            this.listMessagesInTopicAsync(session, topicId, null);
        }
        
        /// <remarks/>
        public void listMessagesInTopicAsync(string session, int topicId, object userState) {
            if ((this.listMessagesInTopicOperationCompleted == null)) {
                this.listMessagesInTopicOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistMessagesInTopicOperationCompleted);
            }
            this.InvokeAsync("listMessagesInTopic", new object[] {
                        session,
                        topicId}, this.listMessagesInTopicOperationCompleted, userState);
        }
        
        private void OnlistMessagesInTopicOperationCompleted(object arg) {
            if ((this.listMessagesInTopicCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listMessagesInTopicCompleted(this, new listMessagesInTopicCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:Message#MessageSOAPApi#createTopic", RequestNamespace="urn:Message", ResponseNamespace="urn:Message")]
        [return: System.Xml.Serialization.SoapElementAttribute("messageObj")]
        public MessageStruct createTopic(string session, int pageId, string subject, string body) {
            object[] results = this.Invoke("createTopic", new object[] {
                        session,
                        pageId,
                        subject,
                        body});
            return ((MessageStruct)(results[0]));
        }
        
        /// <remarks/>
        public void createTopicAsync(string session, int pageId, string subject, string body) {
            this.createTopicAsync(session, pageId, subject, body, null);
        }
        
        /// <remarks/>
        public void createTopicAsync(string session, int pageId, string subject, string body, object userState) {
            if ((this.createTopicOperationCompleted == null)) {
                this.createTopicOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateTopicOperationCompleted);
            }
            this.InvokeAsync("createTopic", new object[] {
                        session,
                        pageId,
                        subject,
                        body}, this.createTopicOperationCompleted, userState);
        }
        
        private void OncreateTopicOperationCompleted(object arg) {
            if ((this.createTopicCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createTopicCompleted(this, new createTopicCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:Message#MessageSOAPApi#createReply", RequestNamespace="urn:Message", ResponseNamespace="urn:Message")]
        [return: System.Xml.Serialization.SoapElementAttribute("messageObj")]
        public MessageStruct createReply(string session, int topicId, string subject, string body) {
            object[] results = this.Invoke("createReply", new object[] {
                        session,
                        topicId,
                        subject,
                        body});
            return ((MessageStruct)(results[0]));
        }
        
        /// <remarks/>
        public void createReplyAsync(string session, int topicId, string subject, string body) {
            this.createReplyAsync(session, topicId, subject, body, null);
        }
        
        /// <remarks/>
        public void createReplyAsync(string session, int topicId, string subject, string body, object userState) {
            if ((this.createReplyOperationCompleted == null)) {
                this.createReplyOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateReplyOperationCompleted);
            }
            this.InvokeAsync("createReply", new object[] {
                        session,
                        topicId,
                        subject,
                        body}, this.createReplyOperationCompleted, userState);
        }
        
        private void OncreateReplyOperationCompleted(object arg) {
            if ((this.createReplyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createReplyCompleted(this, new createReplyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:Message#MessageSOAPApi#deleteMessage", RequestNamespace="urn:Message", ResponseNamespace="urn:Message")]
        [return: System.Xml.Serialization.SoapElementAttribute("result")]
        public bool deleteMessage(string session, int messageId) {
            object[] results = this.Invoke("deleteMessage", new object[] {
                        session,
                        messageId});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void deleteMessageAsync(string session, int messageId) {
            this.deleteMessageAsync(session, messageId, null);
        }
        
        /// <remarks/>
        public void deleteMessageAsync(string session, int messageId, object userState) {
            if ((this.deleteMessageOperationCompleted == null)) {
                this.deleteMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteMessageOperationCompleted);
            }
            this.InvokeAsync("deleteMessage", new object[] {
                        session,
                        messageId}, this.deleteMessageOperationCompleted, userState);
        }
        
        private void OndeleteMessageOperationCompleted(object arg) {
            if ((this.deleteMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteMessageCompleted(this, new deleteMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://www.wikispaces.com/message/api")]
    public partial class MessageStruct {
        
        private int idField;
        
        private string subjectField;
        
        private int bodyField;
        
        private int htmlField;
        
        private int page_idField;
        
        private int topic_idField;
        
        private int responsesField;
        
        private int latest_response_idField;
        
        private int date_responseField;
        
        private int user_createdField;
        
        private string user_created_usernameField;
        
        private int date_createdField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        public int body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
        
        /// <remarks/>
        public int html {
            get {
                return this.htmlField;
            }
            set {
                this.htmlField = value;
            }
        }
        
        /// <remarks/>
        public int page_id {
            get {
                return this.page_idField;
            }
            set {
                this.page_idField = value;
            }
        }
        
        /// <remarks/>
        public int topic_id {
            get {
                return this.topic_idField;
            }
            set {
                this.topic_idField = value;
            }
        }
        
        /// <remarks/>
        public int responses {
            get {
                return this.responsesField;
            }
            set {
                this.responsesField = value;
            }
        }
        
        /// <remarks/>
        public int latest_response_id {
            get {
                return this.latest_response_idField;
            }
            set {
                this.latest_response_idField = value;
            }
        }
        
        /// <remarks/>
        public int date_response {
            get {
                return this.date_responseField;
            }
            set {
                this.date_responseField = value;
            }
        }
        
        /// <remarks/>
        public int user_created {
            get {
                return this.user_createdField;
            }
            set {
                this.user_createdField = value;
            }
        }
        
        /// <remarks/>
        public string user_created_username {
            get {
                return this.user_created_usernameField;
            }
            set {
                this.user_created_usernameField = value;
            }
        }
        
        /// <remarks/>
        public int date_created {
            get {
                return this.date_createdField;
            }
            set {
                this.date_createdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void listTopicsCompletedEventHandler(object sender, listTopicsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listTopicsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listTopicsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MessageStruct[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MessageStruct[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void listMessagesInTopicCompletedEventHandler(object sender, listMessagesInTopicCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listMessagesInTopicCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listMessagesInTopicCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MessageStruct[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MessageStruct[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void createTopicCompletedEventHandler(object sender, createTopicCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createTopicCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createTopicCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MessageStruct Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MessageStruct)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void createReplyCompletedEventHandler(object sender, createReplyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createReplyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createReplyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MessageStruct Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MessageStruct)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void deleteMessageCompletedEventHandler(object sender, deleteMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591