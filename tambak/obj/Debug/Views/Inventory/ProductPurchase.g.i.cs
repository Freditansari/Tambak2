﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak2\Tambak\branches\NewFix\new\tambak\Views\Inventory\ProductPurchase.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C4C5412BF6EFDC9A14D5E3B240EA2E9C"
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
    
    
    public partial class ProductPurchase : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadTabItem RadTabItem;
        
        internal Telerik.Windows.Controls.RadGridView productRadGridView;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox productIDTextBox;
        
        internal System.Windows.Controls.Grid grid2;
        
        internal System.Windows.Controls.TextBox currencyTextBox;
        
        internal System.Windows.Controls.DatePicker dateDatePicker;
        
        internal System.Windows.Controls.DatePicker expireDateDatePicker;
        
        internal System.Windows.Controls.TextBox purchaseLogIDTextBox;
        
        internal System.Windows.Controls.TextBox purchasePriceTextBox;
        
        internal System.Windows.Controls.TextBox quantityTextBox;
        
        internal System.Windows.Controls.TextBox requesterTextBox;
        
        internal System.Windows.Controls.TextBox shippingTextBox;
        
        internal System.Windows.Controls.TextBox totalTextBox;
        
        internal System.Windows.Controls.TextBox batchIDTextBox;
        
        internal System.Windows.Controls.CheckBox isDeliveredCheckBox;
        
        internal System.Windows.Controls.CheckBox isSynchronizedCheckBox;
        
        internal System.Windows.Controls.TextBox locationTextBox;
        
        internal System.Windows.Controls.TextBox taxTextBox;
        
        internal System.Windows.Controls.TextBox userIDTextBox;
        
        internal System.Windows.Controls.DomainDataSource productDomainDataSource;
        
        internal System.Windows.Controls.DomainDataSource productPurchaseLogDomainDataSource;
        
        internal System.Windows.Controls.Button SaveButton;
        
        internal Telerik.Windows.Controls.RadTabItem RadTabItem1;
        
        internal System.Windows.Controls.Grid grid3;
        
        internal System.Windows.Controls.TextBox containerIDTextBox;
        
        internal System.Windows.Controls.TextBox locationTextBox1;
        
        internal System.Windows.Controls.TextBox lotNumberTextBox;
        
        internal System.Windows.Controls.TextBox productIDTextBox1;
        
        internal System.Windows.Controls.TextBox purchaseLogIDTextBox1;
        
        internal System.Windows.Controls.TextBox quantityTextBox1;
        
        internal System.Windows.Controls.DatePicker expireDateDatePicker1;
        
        internal System.Windows.Controls.DatePicker trxDateDatePicker;
        
        internal System.Windows.Controls.TextBox userIDTextBox1;
        
        internal Telerik.Windows.Controls.RadGridView productPurchaseLogRadGridView;
        
        internal System.Windows.Controls.TextBlock ServerTimeTextBlock;
        
        internal System.Windows.Controls.DomainDataSource productQuantityDomainDataSource;
        
        internal System.Windows.Controls.CheckBox IsDeliveryComplete;
        
        internal System.Windows.Controls.Button SaveProductInventoryButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Inventory/ProductPurchase.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RadTabItem = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("RadTabItem")));
            this.productRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("productRadGridView")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.productIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productIDTextBox")));
            this.grid2 = ((System.Windows.Controls.Grid)(this.FindName("grid2")));
            this.currencyTextBox = ((System.Windows.Controls.TextBox)(this.FindName("currencyTextBox")));
            this.dateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("dateDatePicker")));
            this.expireDateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("expireDateDatePicker")));
            this.purchaseLogIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("purchaseLogIDTextBox")));
            this.purchasePriceTextBox = ((System.Windows.Controls.TextBox)(this.FindName("purchasePriceTextBox")));
            this.quantityTextBox = ((System.Windows.Controls.TextBox)(this.FindName("quantityTextBox")));
            this.requesterTextBox = ((System.Windows.Controls.TextBox)(this.FindName("requesterTextBox")));
            this.shippingTextBox = ((System.Windows.Controls.TextBox)(this.FindName("shippingTextBox")));
            this.totalTextBox = ((System.Windows.Controls.TextBox)(this.FindName("totalTextBox")));
            this.batchIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("batchIDTextBox")));
            this.isDeliveredCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("isDeliveredCheckBox")));
            this.isSynchronizedCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("isSynchronizedCheckBox")));
            this.locationTextBox = ((System.Windows.Controls.TextBox)(this.FindName("locationTextBox")));
            this.taxTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taxTextBox")));
            this.userIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("userIDTextBox")));
            this.productDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("productDomainDataSource")));
            this.productPurchaseLogDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("productPurchaseLogDomainDataSource")));
            this.SaveButton = ((System.Windows.Controls.Button)(this.FindName("SaveButton")));
            this.RadTabItem1 = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("RadTabItem1")));
            this.grid3 = ((System.Windows.Controls.Grid)(this.FindName("grid3")));
            this.containerIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("containerIDTextBox")));
            this.locationTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("locationTextBox1")));
            this.lotNumberTextBox = ((System.Windows.Controls.TextBox)(this.FindName("lotNumberTextBox")));
            this.productIDTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("productIDTextBox1")));
            this.purchaseLogIDTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("purchaseLogIDTextBox1")));
            this.quantityTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("quantityTextBox1")));
            this.expireDateDatePicker1 = ((System.Windows.Controls.DatePicker)(this.FindName("expireDateDatePicker1")));
            this.trxDateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("trxDateDatePicker")));
            this.userIDTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("userIDTextBox1")));
            this.productPurchaseLogRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("productPurchaseLogRadGridView")));
            this.ServerTimeTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("ServerTimeTextBlock")));
            this.productQuantityDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("productQuantityDomainDataSource")));
            this.IsDeliveryComplete = ((System.Windows.Controls.CheckBox)(this.FindName("IsDeliveryComplete")));
            this.SaveProductInventoryButton = ((System.Windows.Controls.Button)(this.FindName("SaveProductInventoryButton")));
        }
    }
}

