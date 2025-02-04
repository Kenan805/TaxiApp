﻿#pragma checksum "..\..\..\Views\ForgotPasswordPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F63A5D8BAB6B385CDD3864A0044EFEAA0C73A5E47ED088CFC0E28E3B911DC2B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using TaxiApp.Models;
using TaxiApp.Services;
using TaxiApp.Views;


namespace TaxiApp.Views {
    
    
    /// <summary>
    /// ForgotPasswordPage
    /// </summary>
    public partial class ForgotPasswordPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\..\Views\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEmail;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbVertfCode;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Views\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSendCode;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Views\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbPassword;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\Views\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbConfirmPass;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\Views\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdatePass;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\Views\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/TaxiApp;component/views/forgotpasswordpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ForgotPasswordPage.xaml"
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
            this.tbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbVertfCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnSendCode = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.pbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.pbConfirmPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.btnUpdatePass = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

