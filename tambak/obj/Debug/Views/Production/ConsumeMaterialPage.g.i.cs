﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak2\Tambak\branches\NewFix\new\tambak\Views\Production\ConsumeMaterialPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "781787FD22B49C876FCE60876F75D042"
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


namespace tambak.Views.Production {
    
    
    public partial class ConsumeMaterialPage : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button SelectProductButton;
        
        internal System.Windows.Controls.DataGrid SelectedProductDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn productIDColumn1;
        
        internal System.Windows.Controls.DataGridTextColumn productNameColumn1;
        
        internal System.Windows.Controls.DataGridTextColumn sKUColumn1;
        
        internal System.Windows.Controls.DataGridTextColumn uomColumn1;
        
        internal System.Windows.Controls.DataGridTextColumn product_DescriptionColumn1;
        
        internal System.Windows.Controls.DomainDataSource pondConsumptionsLogDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox batchDetailIDTextBox;
        
        internal System.Windows.Controls.TextBox batchHeaderIDTextBox;
        
        internal System.Windows.Controls.TextBox buyPriceTextBox;
        
        internal System.Windows.Controls.DatePicker logDateDatePicker;
        
        internal System.Windows.Controls.TextBox logIDTextBox;
        
        internal System.Windows.Controls.TextBox noteTextBox;
        
        internal System.Windows.Controls.TextBox pondIDTextBox;
        
        internal System.Windows.Controls.TextBox productGroupIDTextBox;
        
        internal System.Windows.Controls.TextBox productIDTextBox;
        
        internal System.Windows.Controls.TextBox productionCycleIDTextBox;
        
        internal System.Windows.Controls.TextBox qtyTextBox;
        
        internal System.Windows.Controls.TextBox uOMTextBox;
        
        internal System.Windows.Controls.TextBox userIdTextBox;
        
        internal System.Windows.Controls.DomainDataSource pondDomainDataSource;
        
        internal System.Windows.Controls.Grid grid2;
        
        internal System.Windows.Controls.ComboBox pondDescriptionComboBox;
        
        internal System.Windows.Controls.Button SaveButton;
        
        internal System.Windows.Controls.DataGrid batchQtyDataGrid;
        
        internal System.Windows.Controls.Button newBatchButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Production/ConsumeMaterialPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.SelectProductButton = ((System.Windows.Controls.Button)(this.FindName("SelectProductButton")));
            this.SelectedProductDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("SelectedProductDataGrid")));
            this.productIDColumn1 = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("productIDColumn1")));
            this.productNameColumn1 = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("productNameColumn1")));
            this.sKUColumn1 = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("sKUColumn1")));
            this.uomColumn1 = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("uomColumn1")));
            this.product_DescriptionColumn1 = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("product_DescriptionColumn1")));
            this.pondConsumptionsLogDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondConsumptionsLogDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.batchDetailIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("batchDetailIDTextBox")));
            this.batchHeaderIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("batchHeaderIDTextBox")));
            this.buyPriceTextBox = ((System.Windows.Controls.TextBox)(this.FindName("buyPriceTextBox")));
            this.logDateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("logDateDatePicker")));
            this.logIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("logIDTextBox")));
            this.noteTextBox = ((System.Windows.Controls.TextBox)(this.FindName("noteTextBox")));
            this.pondIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pondIDTextBox")));
            this.productGroupIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productGroupIDTextBox")));
            this.productIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productIDTextBox")));
            this.productionCycleIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productionCycleIDTextBox")));
            this.qtyTextBox = ((System.Windows.Controls.TextBox)(this.FindName("qtyTextBox")));
            this.uOMTextBox = ((System.Windows.Controls.TextBox)(this.FindName("uOMTextBox")));
            this.userIdTextBox = ((System.Windows.Controls.TextBox)(this.FindName("userIdTextBox")));
            this.pondDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondDomainDataSource")));
            this.grid2 = ((System.Windows.Controls.Grid)(this.FindName("grid2")));
            this.pondDescriptionComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("pondDescriptionComboBox")));
            this.SaveButton = ((System.Windows.Controls.Button)(this.FindName("SaveButton")));
            this.batchQtyDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("batchQtyDataGrid")));
            this.newBatchButton = ((System.Windows.Controls.Button)(this.FindName("newBatchButton")));
        }
    }
}

