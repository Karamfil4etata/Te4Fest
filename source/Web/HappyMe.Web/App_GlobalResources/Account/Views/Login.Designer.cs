﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.Account.Views {
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
    public class Login {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Login() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HappyMe.Web.App_GlobalResources.Account.Views.Login", typeof(Login).Assembly);
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
        ///   Looks up a localized string similar to Забравена парола?.
        /// </summary>
        public static string Forgoten_password_link {
            get {
                return ResourceManager.GetString("Forgoten_password_link", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Влез.
        /// </summary>
        public static string Login_button {
            get {
                return ResourceManager.GetString("Login_button", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Нямате регистрация?.
        /// </summary>
        public static string No_registration_link {
            get {
                return ResourceManager.GetString("No_registration_link", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Въведете парола....
        /// </summary>
        public static string Password_placeholder {
            get {
                return ResourceManager.GetString("Password_placeholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Вход за потребители.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Въведете потребител....
        /// </summary>
        public static string Username_placeholder {
            get {
                return ResourceManager.GetString("Username_placeholder", resourceCulture);
            }
        }
    }
}
