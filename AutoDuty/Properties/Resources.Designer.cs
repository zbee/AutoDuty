﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoDuty.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AutoDuty.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;Name&quot;: &quot;AutoDuty&quot;,
        ///  &quot;Modules&quot;: {
        ///    &quot;BossMod.Autorotation.xan.BLM&quot;: [
        ///      {
        ///        &quot;Track&quot;: &quot;Targeting&quot;,
        ///        &quot;Option&quot;: &quot;Auto&quot;
        ///      },
        ///      {
        ///        &quot;Track&quot;: &quot;AOE&quot;,
        ///        &quot;Option&quot;: &quot;AOE&quot;
        ///      },
        ///      {
        ///        &quot;Track&quot;: &quot;Buffs&quot;,
        ///        &quot;Option&quot;: &quot;Auto&quot;
        ///      }
        ///    ],
        ///    &quot;BossMod.Autorotation.xan.PCT&quot;: [
        ///      {
        ///        &quot;Track&quot;: &quot;Targeting&quot;,
        ///        &quot;Option&quot;: &quot;Auto&quot;
        ///      },
        ///      {
        ///        &quot;Track&quot;: &quot;AOE&quot;,
        ///        &quot;Option&quot;: &quot;AOE&quot;
        ///      },
        ///      {
        ///        &quot;Track [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AutoDutyPreset {
            get {
                return ResourceManager.GetString("AutoDutyPreset", resourceCulture);
            }
        }
    }
}