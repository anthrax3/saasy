﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaaSy.Web.Resources.Areas.Identity.Pages.Account.Manage {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResetAuthenticator {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResetAuthenticator() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SaaSy.Web.Resources.Areas.Identity.Pages.Account.Manage.ResetAuthenticator", typeof(ResetAuthenticator).Assembly);
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
        ///   Looks up a localized string similar to This process disables 2FA until you verify your authenticator app. If you do not complete your authenticator app configuration you may lose access to your account..
        /// </summary>
        public static string Disabled2FACompleteConfig {
            get {
                return ResourceManager.GetString("Disabled2FACompleteConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you reset your authenticator key your authenticator app will not work until you reconfigure it..
        /// </summary>
        public static string NeedToReconfigApp {
            get {
                return ResourceManager.GetString("NeedToReconfigApp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset authenticator key.
        /// </summary>
        public static string ResetAuthenticatorKey {
            get {
                return ResourceManager.GetString("ResetAuthenticatorKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset authenticator key.
        /// </summary>
        public static string ResetAuthenticatorKeyButton {
            get {
                return ResourceManager.GetString("ResetAuthenticatorKeyButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your authenticator app key has been reset, you will need to configure your authenticator app using the new key..
        /// </summary>
        public static string StatusMessageText {
            get {
                return ResourceManager.GetString("StatusMessageText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load user with ID &apos;{0}&apos;..
        /// </summary>
        public static string UnableToLoadUser {
            get {
                return ResourceManager.GetString("UnableToLoadUser", resourceCulture);
            }
        }
    }
}