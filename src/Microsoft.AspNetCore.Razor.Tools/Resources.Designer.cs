﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.Razor.Tools {
    using System;
    using System.Reflection;


    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        internal Resources() {
        }

        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.Razor.Tools.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Could not parse provided protocol &apos;{0}&apos;. Protocols should be valid int32 values..
        /// </summary>
        public static string CouldNotParseProvidedProtocol {
            get {
                return ResourceManager.GetString("CouldNotParseProvidedProtocol", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Failed to execute razor-tooling: &apos;{0}&apos;..
        /// </summary>
        public static string FailedToExecuteRazorTooling {
            get {
                return ResourceManager.GetString("FailedToExecuteRazorTooling", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to &apos;{0}&apos;s cannot be resolved with protocol &apos;{1}&apos;. Protocol not supported..
        /// </summary>
        public static string InvalidProtocolValue {
            get {
                return ResourceManager.GetString("InvalidProtocolValue", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to Project &apos;{0}&apos; does not support the provided framework &apos;{1}&apos;..
        /// </summary>
        public static string ProjectDoesNotSupportProvidedFramework {
            get {
                return ResourceManager.GetString("ProjectDoesNotSupportProvidedFramework", resourceCulture);
            }
        }
    }
}