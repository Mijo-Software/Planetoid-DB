﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planetoid_DB.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.13.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.minorplanetcenter.org/iau/MPCORB/MPCORB.DAT.gz")]
        public string systemMpcorbDatGzUrl {
            get {
                return ((string)(this["systemMpcorbDatGzUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string userMpcorbDatGzUrl {
            get {
                return ((string)(this["userMpcorbDatGzUrl"]));
            }
            set {
                this["userMpcorbDatGzUrl"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.minorplanetcenter.org/iau/MPCORB/MPCORB.DAT")]
        public string systemMpcorbDatUrl {
            get {
                return ((string)(this["systemMpcorbDatUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string userMpcorbDatUrl {
            get {
                return ((string)(this["userMpcorbDatUrl"]));
            }
            set {
                this["userMpcorbDatUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string userAstorbDatUrl {
            get {
                return ((string)(this["userAstorbDatUrl"]));
            }
            set {
                this["userAstorbDatUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string userAstorbDatGzUrl {
            get {
                return ((string)(this["userAstorbDatGzUrl"]));
            }
            set {
                this["userAstorbDatGzUrl"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://ftp.lowell.edu/pub/elgb/astorb.dat")]
        public string systemAstorbDatUrl {
            get {
                return ((string)(this["systemAstorbDatUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://ftp.lowell.edu/pub/elgb/astorb.dat.gz")]
        public string systemAstorbDatGzUrl {
            get {
                return ((string)(this["systemAstorbDatGzUrl"]));
            }
        }
    }
}
