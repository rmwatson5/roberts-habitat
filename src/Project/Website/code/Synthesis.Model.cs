//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Project.Website.Models {
    
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Basic Homepage template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{E8C2D430-B4EA-4ED8-A56C-8B287EC25865}", "5DIIjeJfXE9guWpvcZomqJJP/go=", "Sitecore.Project.Website")]
    public partial interface IBasicHomepageItem : global::Sitecore.Feature.PageContent.Models.I_BaseHomepageItem, global::Sitecore.Project.Website.Models.IBasicWebpageItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Basic Site Root template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{7CB70EF0-11BE-4B11-95CA-791FD3D5E486}", "gzrqiMWGyvdr0Iv+hGGVyhMtSdk=", "Sitecore.Project.Website")]
    public partial interface IBasicSiteRootItem : global::Sitecore.Feature.PageContent.Models.I_BaseSiteRootItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Basic Webpage template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{27C9E067-9FB2-438E-A695-8718703AEC5E}", "Praj3cIWovbgqY+z5lvxEWee1k4=", "Sitecore.Project.Website")]
    public partial interface IBasicWebpageItem : global::Sitecore.Feature.PageContent.Models.I_BaseWebpageItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Global Folder template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{2F49739B-D15E-4673-AFBF-B20331227224}", "YAxmFofg/hYGSREE+GoH8gAtIR4=", "Sitecore.Project.Website")]
    public partial interface IGlobalFolderItem : global::Sitecore.Foundation.DataAccess.Models.I_BaseStandardTemplateItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Local Content Folder template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{24A091BD-0F15-469E-88FC-385A521BA3EA}", "v4UL3uFLHldQJbiuIJY1dvuJ/NA=", "Sitecore.Project.Website")]
    public partial interface ILocalContentFolderItem : global::Sitecore.Foundation.DataAccess.Models.I_BaseStandardTemplateItem {
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

namespace Sitecore.Project.Website.Models.Concrete {
    
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Basic Homepage template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class BasicHomepage : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.IBasicHomepageItem {
        
        public BasicHomepage(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public BasicHomepage(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Basic Homepage";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{E8C2D430-B4EA-4ED8-A56C-8B287EC25865}");
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
    public class BasicHomepageInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{E8C2D430-B4EA-4ED8-A56C-8B287EC25865}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new BasicHomepage(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new BasicHomepage(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Basic Site Root template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class BasicSiteRoot : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.IBasicSiteRootItem {
        
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
        
        public BasicSiteRoot(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public BasicSiteRoot(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Basic Site Root";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{7CB70EF0-11BE-4B11-95CA-791FD3D5E486}");
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
                    _on = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{3461D229-285D-495C-9919-1F4C135461A1}"], "/sitecore/templates/Project/Website/Basic Site Root", "On"), this.GetSearchFieldValue("on"));
                }
                return _on;
            }
        }
        
        /// <summary>Represents the Scheme field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("scheme")]
        public Synthesis.FieldTypes.Interfaces.ITextField Scheme {
            get {
                if (_scheme == null) {
                    _scheme = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{811B6963-3E37-46B2-B7EE-99ED0ADC4359}"], "/sitecore/templates/Project/Website/Basic Site Root", "Scheme"), this.GetSearchFieldValue("scheme"));
                }
                return _scheme;
            }
        }
        
        /// <summary>Represents the Target Host Name field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("target_host_name")]
        public Synthesis.FieldTypes.Interfaces.ITextField TargetHostName {
            get {
                if (_targetHostName == null) {
                    _targetHostName = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{B8B3CB32-4C04-4073-887E-4B5E11EAEC80}"], "/sitecore/templates/Project/Website/Basic Site Root", "Target Host Name"), this.GetSearchFieldValue("target_host_name"));
                }
                return _targetHostName;
            }
        }
        
        /// <summary>Represents the Language field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("language")]
        public Synthesis.FieldTypes.Interfaces.IItemReferenceField Language1 {
            get {
                if (_language1 == null) {
                    _language1 = new Synthesis.FieldTypes.ItemReferenceField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{370C2996-5C2A-4B25-B062-B8FCF575DD9D}"], "/sitecore/templates/Project/Website/Basic Site Root", "Language"), this.GetSearchFieldValue("language"));
                }
                return _language1;
            }
        }
        
        /// <summary>Represents the Login Page field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("login_page")]
        public Synthesis.FieldTypes.Interfaces.IItemReferenceField LoginPage {
            get {
                if (_loginPage == null) {
                    _loginPage = new Synthesis.FieldTypes.ItemReferenceField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{453EBC8B-F894-4F08-A348-20ECDE37F50F}"], "/sitecore/templates/Project/Website/Basic Site Root", "Login Page"), this.GetSearchFieldValue("login_page"));
                }
                return _loginPage;
            }
        }
        
        /// <summary>Represents the Require Login field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("require_login")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField RequireLogin {
            get {
                if (_requireLogin == null) {
                    _requireLogin = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{9CFF6A68-26D2-48D3-B1B7-DBDE2184C098}"], "/sitecore/templates/Project/Website/Basic Site Root", "Require Login"), this.GetSearchFieldValue("require_login"));
                }
                return _requireLogin;
            }
        }
        
        /// <summary>Represents the Domain field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("domain")]
        public Synthesis.FieldTypes.Interfaces.ITextField Domain {
            get {
                if (_domain == null) {
                    _domain = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{E04D9034-4D40-46EA-A63D-DD6AD65052E6}"], "/sitecore/templates/Project/Website/Basic Site Root", "Domain"), this.GetSearchFieldValue("domain"));
                }
                return _domain;
            }
        }
        
        /// <summary>Represents the Enable Workflow field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("enable_workflow")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField EnableWorkflow {
            get {
                if (_enableWorkflow == null) {
                    _enableWorkflow = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{FC19D520-9E22-4FE2-A55E-45BB33FB4A6D}"], "/sitecore/templates/Project/Website/Basic Site Root", "Enable Workflow"), this.GetSearchFieldValue("enable_workflow"));
                }
                return _enableWorkflow;
            }
        }
        
        /// <summary>Represents the Enable Preview field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("enable_preview")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField EnablePreview {
            get {
                if (_enablePreview == null) {
                    _enablePreview = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{9EC8B9D9-29DE-4939-9757-FEB155304979}"], "/sitecore/templates/Project/Website/Basic Site Root", "Enable Preview"), this.GetSearchFieldValue("enable_preview"));
                }
                return _enablePreview;
            }
        }
        
        /// <summary>Represents the Allow Debug field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("allow_debug")]
        public Synthesis.FieldTypes.Interfaces.IBooleanField AllowDebug {
            get {
                if (_allowDebug == null) {
                    _allowDebug = new Synthesis.FieldTypes.BooleanField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{5A1AF457-8706-4685-8545-53E632C74B0C}"], "/sitecore/templates/Project/Website/Basic Site Root", "Allow Debug"), this.GetSearchFieldValue("allow_debug"));
                }
                return _allowDebug;
            }
        }
        
        /// <summary>Represents the Browser Title field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("browser_title")]
        public Synthesis.FieldTypes.Interfaces.ITextField BrowserTitle {
            get {
                if (_browserTitle == null) {
                    _browserTitle = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{D21C5BEB-FF61-4F0A-99E4-019F0A429113}"], "/sitecore/templates/Project/Website/Basic Site Root", "Browser Title"), this.GetSearchFieldValue("browser_title"));
                }
                return _browserTitle;
            }
        }
        
        /// <summary>Represents the Additional Attributes field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("additional_attributes")]
        public Synthesis.FieldTypes.Interfaces.IDictionaryField AdditionalAttributes {
            get {
                if (_additionalAttributes == null) {
                    _additionalAttributes = new Synthesis.FieldTypes.DictionaryField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{F80A2ADA-7D2A-4D79-B5FD-ABA251D02C5E}"], "/sitecore/templates/Project/Website/Basic Site Root", "Additional Attributes"), this.GetSearchFieldValue("additional_attributes"));
                }
                return _additionalAttributes;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public class BasicSiteRootInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{7CB70EF0-11BE-4B11-95CA-791FD3D5E486}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new BasicSiteRoot(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new BasicSiteRoot(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Basic Webpage template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class BasicWebpage : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.IBasicWebpageItem {
        
        public BasicWebpage(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public BasicWebpage(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Basic Webpage";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{27C9E067-9FB2-438E-A695-8718703AEC5E}");
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
    public class BasicWebpageInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{27C9E067-9FB2-438E-A695-8718703AEC5E}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new BasicWebpage(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new BasicWebpage(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Global Folder template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class GlobalFolder : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.IGlobalFolderItem {
        
        public GlobalFolder(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public GlobalFolder(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Global Folder";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{2F49739B-D15E-4673-AFBF-B20331227224}");
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
    public class GlobalFolderInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{2F49739B-D15E-4673-AFBF-B20331227224}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new GlobalFolder(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new GlobalFolder(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Local Content Folder template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.0")]
    public partial class LocalContentFolder : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.ILocalContentFolderItem {
        
        public LocalContentFolder(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public LocalContentFolder(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Local Content Folder";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{24A091BD-0F15-469E-88FC-385A521BA3EA}");
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
    public class LocalContentFolderInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{24A091BD-0F15-469E-88FC-385A521BA3EA}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new LocalContentFolder(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new LocalContentFolder(searchFields);
        }
    }
}
