﻿#pragma checksum "..\..\..\pages\ProvidersViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17DE63B86CD0E71ED397C2474DCD72A502F548E22FF243CE4E50411AF6E6F7DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Providers.pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Providers.pages {
    
    
    /// <summary>
    /// ProvidersViewPage
    /// </summary>
    public partial class ProvidersViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\pages\ProvidersViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchBar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\pages\ProvidersViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox orderSelect;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pages\ProvidersViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Providers;component/pages/providersviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\ProvidersViewPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\pages\ProvidersViewPage.xaml"
            ((Providers.pages.ProvidersViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.updateListView);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\pages\ProvidersViewPage.xaml"
            this.searchBar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchBarInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.orderSelect = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\pages\ProvidersViewPage.xaml"
            this.orderSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.orderChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

