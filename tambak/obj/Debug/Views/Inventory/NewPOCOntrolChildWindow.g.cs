﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak2\Tambak\branches\NewFix\new\tambak\Views\Inventory\NewPOCOntrolChildWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E0919266D565E442CAF2EE020C32E6F9"
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


namespace tambak.Views.Inventory {
    
    
    public partial class NewPOCOntrolChildWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DomainDataSource pDOControlDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox accountingNotesTextBox;
        
        internal System.Windows.Controls.TextBox buyPriceTextBox;
        
        internal System.Windows.Controls.DatePicker dateDatePicker;
        
        internal System.Windows.Controls.TextBox iDTextBox;
        
        internal System.Windows.Controls.TextBox inventoryIDTextBox;
        
        internal System.Windows.Controls.TextBox inventoryNameTextBox;
        
        internal System.Windows.Controls.TextBox noPDOTextBox;
        
        internal System.Windows.Controls.TextBox orderedQuantityTextBox;
        
        internal System.Windows.Controls.TextBox receivedNotesTextBox;
        
        internal System.Windows.Controls.TextBox receivedQuantityTextBox;
        
        internal System.Windows.Controls.TextBox uOMTextBox;
        
        internal System.Windows.Controls.CheckBox isClosedCheckBox;
        
        internal System.Windows.Controls.CheckBox isOrderedCheckBox;
        
        internal System.Windows.Controls.CheckBox isPaidCheckBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Inventory/NewPOCOntrolChildWindow.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.pDOControlDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pDOControlDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.accountingNotesTextBox = ((System.Windows.Controls.TextBox)(this.FindName("accountingNotesTextBox")));
            this.buyPriceTextBox = ((System.Windows.Controls.TextBox)(this.FindName("buyPriceTextBox")));
            this.dateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("dateDatePicker")));
            this.iDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("iDTextBox")));
            this.inventoryIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("inventoryIDTextBox")));
            this.inventoryNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("inventoryNameTextBox")));
            this.noPDOTextBox = ((System.Windows.Controls.TextBox)(this.FindName("noPDOTextBox")));
            this.orderedQuantityTextBox = ((System.Windows.Controls.TextBox)(this.FindName("orderedQuantityTextBox")));
            this.receivedNotesTextBox = ((System.Windows.Controls.TextBox)(this.FindName("receivedNotesTextBox")));
            this.receivedQuantityTextBox = ((System.Windows.Controls.TextBox)(this.FindName("receivedQuantityTextBox")));
            this.uOMTextBox = ((System.Windows.Controls.TextBox)(this.FindName("uOMTextBox")));
            this.isClosedCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("isClosedCheckBox")));
            this.isOrderedCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("isOrderedCheckBox")));
            this.isPaidCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("isPaidCheckBox")));
        }
    }
}
