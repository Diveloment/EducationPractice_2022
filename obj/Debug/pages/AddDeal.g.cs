﻿#pragma checksum "..\..\..\pages\AddDeal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF9A3F800343EA9E3D116E9D1C23BCAB547F07B08C9F82B9B8F3DBD9C71ACABB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
    /// AddDeal
    /// </summary>
    public partial class AddDeal : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboStatus;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker textDate;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboProvider;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textCost;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboContact;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboType;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboSuperviser;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboProduct;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\pages\AddDeal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textCol;
        
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
            System.Uri resourceLocater = new System.Uri("/Providers;component/pages/adddeal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\AddDeal.xaml"
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
            this.comboStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.textName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.comboProvider = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\pages\AddDeal.xaml"
            this.comboProvider.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.providerChange);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.comboContact = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.comboType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.comboSuperviser = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.comboProduct = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.textCol = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 64 "..\..\..\pages\AddDeal.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

