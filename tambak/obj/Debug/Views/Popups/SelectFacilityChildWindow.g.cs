﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak2\Tambak\branches\NewFix\new\tambak\Views\Popups\SelectFacilityChildWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2110067037E855F571E9E2754EEF990A"
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


namespace tambak.Views.Popups {
    
    
    public partial class SelectFacilityChildWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DomainDataSource companyDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.ComboBox companyNameComboBox;
        
        internal System.Windows.Controls.DomainDataSource facilityDomainDataSource;
        
        internal System.Windows.Controls.DataGrid facilityDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn addressColumn;
        
        internal System.Windows.Controls.DataGridTextColumn address2Column;
        
        internal System.Windows.Controls.DataGridTextColumn cityColumn;
        
        internal System.Windows.Controls.DataGridTextColumn companyIDColumn;
        
        internal System.Windows.Controls.DataGridTextColumn contactPersonColumn;
        
        internal System.Windows.Controls.DataGridTextColumn countryColumn;
        
        internal System.Windows.Controls.DataGridTextColumn emailColumn;
        
        internal System.Windows.Controls.DataGridTemplateColumn entryDateColumn;
        
        internal System.Windows.Controls.DataGridTextColumn facilityIdColumn;
        
        internal System.Windows.Controls.DataGridTextColumn facilityNameColumn;
        
        internal System.Windows.Controls.DataGridTextColumn phoneNumberColumn;
        
        internal System.Windows.Controls.DataGridTextColumn stateColumn;
        
        internal System.Windows.Controls.DataGridTextColumn userIDColumn;
        
        internal System.Windows.Controls.DataGridTextColumn zipCodeColumn;
        
        internal System.Windows.Controls.Button addNewFacilityButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Popups/SelectFacilityChildWindow.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.companyDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("companyDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.companyNameComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("companyNameComboBox")));
            this.facilityDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("facilityDomainDataSource")));
            this.facilityDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("facilityDataGrid")));
            this.addressColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("addressColumn")));
            this.address2Column = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("address2Column")));
            this.cityColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("cityColumn")));
            this.companyIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("companyIDColumn")));
            this.contactPersonColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("contactPersonColumn")));
            this.countryColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("countryColumn")));
            this.emailColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("emailColumn")));
            this.entryDateColumn = ((System.Windows.Controls.DataGridTemplateColumn)(this.FindName("entryDateColumn")));
            this.facilityIdColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("facilityIdColumn")));
            this.facilityNameColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("facilityNameColumn")));
            this.phoneNumberColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("phoneNumberColumn")));
            this.stateColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("stateColumn")));
            this.userIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("userIDColumn")));
            this.zipCodeColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("zipCodeColumn")));
            this.addNewFacilityButton = ((System.Windows.Controls.Button)(this.FindName("addNewFacilityButton")));
        }
    }
}

