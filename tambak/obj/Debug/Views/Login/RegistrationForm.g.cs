﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak2\Tambak\branches\NewFix\new\tambak\Views\Login\RegistrationForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E1274AE712594FF4387C21A5F8D9FB16"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using tambak.Controls;


namespace tambak.LoginUI {
    
    
    public partial class RegistrationForm : System.Windows.Controls.StackPanel {
        
        internal tambak.Controls.BusyIndicator busyIndicator;
        
        internal System.Windows.Controls.DataForm registerForm;
        
        internal System.Windows.Controls.Button registerButton;
        
        internal System.Windows.Controls.Button registerCancel;
        
        internal System.Windows.Controls.HyperlinkButton backToLogin;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Login/RegistrationForm.xaml", System.UriKind.Relative));
            this.busyIndicator = ((tambak.Controls.BusyIndicator)(this.FindName("busyIndicator")));
            this.registerForm = ((System.Windows.Controls.DataForm)(this.FindName("registerForm")));
            this.registerButton = ((System.Windows.Controls.Button)(this.FindName("registerButton")));
            this.registerCancel = ((System.Windows.Controls.Button)(this.FindName("registerCancel")));
            this.backToLogin = ((System.Windows.Controls.HyperlinkButton)(this.FindName("backToLogin")));
        }
    }
}
