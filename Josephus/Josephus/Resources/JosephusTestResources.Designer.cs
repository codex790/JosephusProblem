﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Josephus.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class JosephusTestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal JosephusTestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Josephus.Resources.JosephusTestResources", typeof(JosephusTestResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *************************************************************.
        /// </summary>
        public static string Breakline {
            get {
                return ResourceManager.GetString("Breakline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The eliminated children sequence id&apos;s (in order of elimination) are:.
        /// </summary>
        public static string EliminatedChildrenResultText {
            get {
                return ResourceManager.GetString("EliminatedChildrenResultText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Eliminate position must be greater than 0.
        /// </summary>
        public static string EliminatePositionArgumentException {
            get {
                return ResourceManager.GetString("EliminatePositionArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of children should be greater than the eliminate position.
        /// </summary>
        public static string EliminatePositionGreaterThanNumberOfChildrenError {
            get {
                return ResourceManager.GetString("EliminatePositionGreaterThanNumberOfChildrenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the eliminate position:.
        /// </summary>
        public static string EliminatePositonInputText {
            get {
                return ResourceManager.GetString("EliminatePositonInputText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid entry....
        /// </summary>
        public static string InvalidEntryErrorText {
            get {
                return ResourceManager.GetString("InvalidEntryErrorText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no removed children.
        /// </summary>
        public static string NoRemovedChildrenText {
            get {
                return ResourceManager.GetString("NoRemovedChildrenText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of children must be greater than 0.
        /// </summary>
        public static string NumberOfChildrenArgumentException {
            get {
                return ResourceManager.GetString("NumberOfChildrenArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the number of children:.
        /// </summary>
        public static string NumberOfChildrenInputText {
            get {
                return ResourceManager.GetString("NumberOfChildrenInputText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The winning child sequence id is:.
        /// </summary>
        public static string RemainingChildResultText {
            get {
                return ResourceManager.GetString("RemainingChildResultText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Try again? Press Y, otherwise any key to quit....
        /// </summary>
        public static string TryAgainText {
            get {
                return ResourceManager.GetString("TryAgainText", resourceCulture);
            }
        }
    }
}
