﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak2\Tambak\branches\NewFix\new\tambak\Views\Masters\NewTaxChildWindows.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "73DC1B1E39F64DFC8449B5F5C838B06C"
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


namespace tambak.Views.Masters {
    
    
    public partial class NewTaxChildWindows : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DomainDataSource masterTaxDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox taxDescriptionTextBox;
        
        internal System.Windows.Controls.TextBox taxIDTextBox;
        
        internal System.Windows.Controls.TextBox taxRateTextBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Masters/NewTaxChildWindows.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.masterTaxDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("masterTaxDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.taxDescriptionTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taxDescriptionTextBox")));
            this.taxIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taxIDTextBox")));
            this.taxRateTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taxRateTextBox")));
        }
    }
}

