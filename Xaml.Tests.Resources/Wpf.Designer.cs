﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xaml.Tests.Resources {
    using System;
    using System.Reflection;
    
    
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
    public class Wpf {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Wpf() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Xaml.Tests.Resources.Wpf", typeof(Wpf).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;root&quot; Title=&quot;Hello from OmniXaml!&quot; Width=&quot;800&quot; Height=&quot;600&quot;&gt;
        ///  &lt;Grid&gt;
        ///    &lt;Grid.RowDefinitions&gt;
        ///      &lt;RowDefinition /&gt;
        ///      &lt;RowDefinition Height=&quot;Auto&quot; /&gt;
        ///    &lt;/Grid.RowDefinitions&gt;
        ///
        ///    &lt;Grid.ColumnDefinitions&gt;
        ///      &lt;ColumnDefinition /&gt;
        ///      &lt;ColumnDefinition /&gt;
        ///    &lt;/Grid.ColumnDefinitions&gt;
        ///
        ///    &lt;Grid.Children&gt;
        ///      &lt;TextBlock Grid.Column=&quot;1&quot; Grid.Row=&quot;1&quot; Text=&quot;Press F12 for Dev Tools&quot; /&gt;
        ///      &lt;TabControl Grid.ColumnSpan=&quot;2&quot;&gt;
        ///        &lt;TabControl.Items&gt;
        ///          &lt;TabI [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Complex {
            get {
                return ResourceManager.GetString("Complex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window Title=&quot;MainWindow&quot; Height=&quot;350&quot; Width=&quot;525&quot;&gt;
        ///  &lt;Grid&gt;
        ///    &lt;Grid.RowDefinitions&gt;
        ///      &lt;RowDefinition Height=&quot;Auto&quot;/&gt;
        ///      &lt;RowDefinition /&gt;
        ///    &lt;/Grid.RowDefinitions&gt;
        ///    &lt;Menu&gt;
        ///      &lt;MenuItem Header=&quot;File&quot;&gt;
        ///        &lt;MenuItem Header=&quot;Open&quot;&gt;
        ///          &lt;MenuItem.Icon&gt;
        ///            &lt;Image Source=&quot;github_icon.png&quot;&gt;&lt;/Image&gt;
        ///          &lt;/MenuItem.Icon&gt;
        ///        &lt;/MenuItem&gt;
        ///        &lt;MenuItem Header=&quot;Save&quot;&gt;
        ///          &lt;MenuItem Header=&quot;SubItem 1&quot; /&gt;
        ///          &lt;MenuItem Header=&quot;SubItem 2&quot; /&gt;
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ShowCase {
            get {
                return ResourceManager.GetString("ShowCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;root&quot; Title=&quot;Hello OmniXaml!&quot;&gt;
        ///  &lt;Window.Content&gt;
        ///    &lt;Grid&gt;
        ///      &lt;Grid.ColumnDefinitions&gt;
        ///        &lt;ColumnDefinition /&gt;
        ///        &lt;ColumnDefinition /&gt;
        ///      &lt;/Grid.ColumnDefinitions&gt;
        ///      &lt;Grid.Children&gt;
        ///        &lt;TextBlock Text=&quot;XAML is the way&quot; Grid.Column=&quot;0&quot; /&gt;
        ///        &lt;TextBlock Text=&quot;To make you invincible :D&quot; Grid.Column=&quot;1&quot; /&gt;
        ///      &lt;/Grid.Children&gt;
        ///    &lt;/Grid&gt;
        ///  &lt;/Window.Content&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string Stage1 {
            get {
                return ResourceManager.GetString("Stage1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;root&quot;&gt;&lt;/Window&gt;.
        /// </summary>
        public static string Window {
            get {
                return ResourceManager.GetString("Window", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;root&quot;&gt;
        ///  &lt;Window.Content&gt;
        ///    &lt;TextBlock Text=&quot;Saludos cordiales!&quot; /&gt;
        ///  &lt;/Window.Content&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string WindowWithContent {
            get {
                return ResourceManager.GetString("WindowWithContent", resourceCulture);
            }
        }
    }
}
