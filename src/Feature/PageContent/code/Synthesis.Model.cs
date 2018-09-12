//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Feature.PageContent.Models {
    
    
    /// <summary>Represents the /sitecore/templates/Feature/PageContent/Site Settings template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{5BE221A1-4BF0-491F-BD98-C53B3ABFD754}", "FdVDS5Sju8uPW0GVZfJW0+lLNYc=", "Sitecore.Feature.PageContent")]
    public partial interface ISiteSettingsItem : global::Sitecore.Foundation.DataAccess.Models.I_BaseStandardTemplateItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Feature/PageContent/_Base Homepage template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{782EEFC5-FEFE-45F6-B426-13F83CF04A49}", "i1N5PHBPSF6sbzC6bX3k/Rpr04E=", "Sitecore.Feature.PageContent")]
    public partial interface I_BaseHomepageItem : global::Sitecore.Foundation.DataAccess.Models.I_BaseStandardTemplateItem, global::Sitecore.Feature.PageContent.Models.I_BaseWebpageItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Feature/PageContent/_Base Site Root template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{FE98FA96-B717-4D81-9F09-C7255EE07023}", "SecKD03UQQFtwdsQl8MElWinNRg=", "Sitecore.Feature.PageContent")]
    public partial interface I_BaseSiteRootItem : global::Sitecore.Foundation.DataAccess.Models.I_BaseStandardTemplateItem {
        
        /// <summary>Represents the On field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("on")]
        Synthesis.FieldTypes.Interfaces.IBooleanField On {
            get;
        }
        
        /// <summary>Represents the Scheme field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("scheme")]
        Synthesis.FieldTypes.Interfaces.ITextField Scheme {
            get;
        }
        
        /// <summary>Represents the Target Host Name field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("target_host_name")]
        Synthesis.FieldTypes.Interfaces.ITextField TargetHostName {
            get;
        }
        
        /// <summary>Represents the Language field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("language")]
        Synthesis.FieldTypes.Interfaces.IItemReferenceField Language1 {
            get;
        }
        
        /// <summary>Represents the Login Page field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("login_page")]
        Synthesis.FieldTypes.Interfaces.IItemReferenceField LoginPage {
            get;
        }
        
        /// <summary>Represents the Require Login field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("require_login")]
        Synthesis.FieldTypes.Interfaces.IBooleanField RequireLogin {
            get;
        }
        
        /// <summary>Represents the Domain field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("domain")]
        Synthesis.FieldTypes.Interfaces.ITextField Domain {
            get;
        }
        
        /// <summary>Represents the Enable Workflow field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("enable_workflow")]
        Synthesis.FieldTypes.Interfaces.IBooleanField EnableWorkflow {
            get;
        }
        
        /// <summary>Represents the Enable Preview field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("enable_preview")]
        Synthesis.FieldTypes.Interfaces.IBooleanField EnablePreview {
            get;
        }
        
        /// <summary>Represents the Allow Debug field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("allow_debug")]
        Synthesis.FieldTypes.Interfaces.IBooleanField AllowDebug {
            get;
        }
        
        /// <summary>Represents the Browser Title field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("browser_title")]
        Synthesis.FieldTypes.Interfaces.ITextField BrowserTitle {
            get;
        }
        
        /// <summary>Represents the Additional Attributes field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("additional_attributes")]
        Synthesis.FieldTypes.Interfaces.IDictionaryField AdditionalAttributes {
            get;
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Feature/PageContent/_Base Webpage template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{09314C4F-1126-4084-9212-C98C12D5264B}", "KyHjn/URE9n5MNG4mkaHZcdJKjo=", "Sitecore.Feature.PageContent")]
    public partial interface I_BaseWebpageItem : global::Sitecore.Foundation.DataAccess.Models.I_BaseStandardTemplateItem {
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Feature.PageContent.Models.Concrete {
    
    
    /// <summary>Represents the /sitecore/templates/Feature/PageContent/Site Settings template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class SiteSettings : global::Synthesis.StandardTemplateItem, global::Sitecore.Feature.PageContent.Models.ISiteSettingsItem {
        
        public SiteSettings(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public SiteSettings(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Site Settings";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{5BE221A1-4BF0-491F-BD98-C53B3ABFD754}");
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId {
            get {
                return ItemTemplateId;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public class SiteSettingsInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{5BE221A1-4BF0-491F-BD98-C53B3ABFD754}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new SiteSettings(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new SiteSettings(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Feature/PageContent/_Base Homepage template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class _BaseHomepage : global::Synthesis.StandardTemplateItem, global::Sitecore.Feature.PageContent.Models.I_BaseHomepageItem {
        
        public _BaseHomepage(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public _BaseHomepage(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "_Base Homepage";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{782EEFC5-FEFE-45F6-B426-13F83CF04A49}");
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId {
            get {
                return ItemTemplateId;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public class _BaseHomepageInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{782EEFC5-FEFE-45F6-B426-13F83CF04A49}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new _BaseHomepage(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new _BaseHomepage(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Feature/PageContent/_Base Site Root template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class _BaseSiteRoot : global::Synthesis.StandardTemplateItem, global::Sitecore.Feature.PageContent.Models.I_BaseSiteRootItem {
        
        private Synthesis.FieldTypes.BooleanField _on;
        
        private Synthesis.FieldTypes.TextField _scheme;
        
        private Synthesis.FieldTypes.TextField _targetHostName;
        
        private Synthesis.FieldTypes.ItemReferenceField _language1;
        
        private Synthesis.FieldTypes.ItemReferenceField _loginPage;
        
        private Synthesis.FieldTypes.BooleanField _requireLogin;
        
        private Synthesis.FieldTypes.TextField _domain;
        
        private Synthesis.FieldTypes.BooleanField _enableWorkflow;
        
        private Synthesis.FieldTypes.BooleanField _enablePreview;
        
        private Synthesis.FieldTypes.BooleanField _allowDebug;
        
        private Synthesis.FieldTypes.TextField _browserTitle;
        
        private Synthesis.FieldTypes.DictionaryField _additionalAttributes;
        
        public _BaseSiteRoot(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public _BaseSiteRoot(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "_Base Site Root";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{FE98FA96-B717-4D81-9F09-C7255EE07023}");
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId {
            get {
                return ItemTemplateId;
            }
        }
        
        /// <summary>Represents the On field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("on")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField On {
            get {
                if (_on == null) {
                    _on = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{3461D229-285D-495C-9919-1F4C135461A1}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "On"), this.GetSearchFieldValue("on"));
                }
                return _on;
            }
        }
        
        /// <summary>Represents the Scheme field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("scheme")]
        public Synthesis.FieldTypes.Interfaces.ITextField Scheme {
            get {
                if (_scheme == null) {
                    _scheme = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{811B6963-3E37-46B2-B7EE-99ED0ADC4359}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Scheme"), this.GetSearchFieldValue("scheme"));
                }
                return _scheme;
            }
        }
        
        /// <summary>Represents the Target Host Name field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("target_host_name")]
        public Synthesis.FieldTypes.Interfaces.ITextField TargetHostName {
            get {
                if (_targetHostName == null) {
                    _targetHostName = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{B8B3CB32-4C04-4073-887E-4B5E11EAEC80}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Target Host Name"), this.GetSearchFieldValue("target_host_name"));
                }
                return _targetHostName;
            }
        }
        
        /// <summary>Represents the Language field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("language")]
        public Synthesis.FieldTypes.Interfaces.IItemReferenceField Language1 {
            get {
                if (_language1 == null) {
                    _language1 = new Synthesis.FieldTypes.ItemReferenceField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{370C2996-5C2A-4B25-B062-B8FCF575DD9D}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Language"), this.GetSearchFieldValue("language"));
                }
                return _language1;
            }
        }
        
        /// <summary>Represents the Login Page field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("login_page")]
        public Synthesis.FieldTypes.Interfaces.IItemReferenceField LoginPage {
            get {
                if (_loginPage == null) {
                    _loginPage = new Synthesis.FieldTypes.ItemReferenceField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{453EBC8B-F894-4F08-A348-20ECDE37F50F}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Login Page"), this.GetSearchFieldValue("login_page"));
                }
                return _loginPage;
            }
        }
        
        /// <summary>Represents the Require Login field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("require_login")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField RequireLogin {
            get {
                if (_requireLogin == null) {
                    _requireLogin = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{9CFF6A68-26D2-48D3-B1B7-DBDE2184C098}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Require Login"), this.GetSearchFieldValue("require_login"));
                }
                return _requireLogin;
            }
        }
        
        /// <summary>Represents the Domain field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("domain")]
        public Synthesis.FieldTypes.Interfaces.ITextField Domain {
            get {
                if (_domain == null) {
                    _domain = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{E04D9034-4D40-46EA-A63D-DD6AD65052E6}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Domain"), this.GetSearchFieldValue("domain"));
                }
                return _domain;
            }
        }
        
        /// <summary>Represents the Enable Workflow field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("enable_workflow")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField EnableWorkflow {
            get {
                if (_enableWorkflow == null) {
                    _enableWorkflow = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{FC19D520-9E22-4FE2-A55E-45BB33FB4A6D}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Enable Workflow"), this.GetSearchFieldValue("enable_workflow"));
                }
                return _enableWorkflow;
            }
        }
        
        /// <summary>Represents the Enable Preview field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("enable_preview")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField EnablePreview {
            get {
                if (_enablePreview == null) {
                    _enablePreview = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{9EC8B9D9-29DE-4939-9757-FEB155304979}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Enable Preview"), this.GetSearchFieldValue("enable_preview"));
                }
                return _enablePreview;
            }
        }
        
        /// <summary>Represents the Allow Debug field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("allow_debug")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField AllowDebug {
            get {
                if (_allowDebug == null) {
                    _allowDebug = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{5A1AF457-8706-4685-8545-53E632C74B0C}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Allow Debug"), this.GetSearchFieldValue("allow_debug"));
                }
                return _allowDebug;
            }
        }
        
        /// <summary>Represents the Browser Title field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("browser_title")]
        public Synthesis.FieldTypes.Interfaces.ITextField BrowserTitle {
            get {
                if (_browserTitle == null) {
                    _browserTitle = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{D21C5BEB-FF61-4F0A-99E4-019F0A429113}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Browser Title"), this.GetSearchFieldValue("browser_title"));
                }
                return _browserTitle;
            }
        }
        
        /// <summary>Represents the Additional Attributes field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("additional_attributes")]
        public Synthesis.FieldTypes.Interfaces.IDictionaryField AdditionalAttributes {
            get {
                if (_additionalAttributes == null) {
                    _additionalAttributes = new Synthesis.FieldTypes.DictionaryField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{F80A2ADA-7D2A-4D79-B5FD-ABA251D02C5E}"], "/sitecore/templates/Feature/PageContent/_Base Site Root", "Additional Attributes"), this.GetSearchFieldValue("additional_attributes"));
                }
                return _additionalAttributes;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public class _BaseSiteRootInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{FE98FA96-B717-4D81-9F09-C7255EE07023}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new _BaseSiteRoot(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new _BaseSiteRoot(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Feature/PageContent/_Base Webpage template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class _BaseWebpage : global::Synthesis.StandardTemplateItem, global::Sitecore.Feature.PageContent.Models.I_BaseWebpageItem {
        
        public _BaseWebpage(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public _BaseWebpage(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "_Base Webpage";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{09314C4F-1126-4084-9212-C98C12D5264B}");
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId {
            get {
                return ItemTemplateId;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public class _BaseWebpageInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{09314C4F-1126-4084-9212-C98C12D5264B}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new _BaseWebpage(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new _BaseWebpage(searchFields);
        }
    }
}
