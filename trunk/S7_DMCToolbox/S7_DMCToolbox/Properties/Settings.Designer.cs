﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S7_DMCToolbox.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Select a Project")]
        public string ProjectPath {
            get {
                return ((string)(this["ProjectPath"]));
            }
            set {
                this["ProjectPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentlyUsedBlocks {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentlyUsedBlocks"]));
            }
            set {
                this["RecentlyUsedBlocks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool fcFilter {
            get {
                return ((bool)(this["fcFilter"]));
            }
            set {
                this["fcFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool dbFilter {
            get {
                return ((bool)(this["dbFilter"]));
            }
            set {
                this["dbFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool fbFilter {
            get {
                return ((bool)(this["fbFilter"]));
            }
            set {
                this["fbFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool obFilter {
            get {
                return ((bool)(this["obFilter"]));
            }
            set {
                this["obFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool vatFilter {
            get {
                return ((bool)(this["vatFilter"]));
            }
            set {
                this["vatFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool udtFilter {
            get {
                return ((bool)(this["udtFilter"]));
            }
            set {
                this["udtFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool recentFilter {
            get {
                return ((bool)(this["recentFilter"]));
            }
            set {
                this["recentFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string KepwareExportFilePath {
            get {
                return ((string)(this["KepwareExportFilePath"]));
            }
            set {
                this["KepwareExportFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AlarmWorxExportFilePath {
            get {
                return ((string)(this["AlarmWorxExportFilePath"]));
            }
            set {
                this["AlarmWorxExportFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentOPCServers {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentOPCServers"]));
            }
            set {
                this["RecentOPCServers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentAlarmFolderNames {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentAlarmFolderNames"]));
            }
            set {
                this["RecentAlarmFolderNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string WinCCFlexDigitalAlarmsExportFilePath {
            get {
                return ((string)(this["WinCCFlexDigitalAlarmsExportFilePath"]));
            }
            set {
                this["WinCCFlexDigitalAlarmsExportFilePath"] = value;
            }
        }
    }
}
