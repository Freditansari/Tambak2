﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak\branches\NewFix\new\tambak\Views\PondStatus.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DC471A3AF9DD3B406ED88C9981B089C"
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


namespace tambak.Views {
    
    
    public partial class PondStatus : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadTabItem RadTabItem;
        
        internal Telerik.Windows.Controls.RadGridView pondRadGridView;
        
        internal System.Windows.Controls.DomainDataSource pondDomainDataSource;
        
        internal Telerik.Windows.Controls.RadGridView pondsProductionCycleRadGridView;
        
        internal System.Windows.Controls.DomainDataSource pondsProductionCycleDomainDataSource;
        
        internal Telerik.Windows.Controls.RadTabItem pondStatusRadTabItem;
        
        internal Telerik.Windows.Controls.RadGridView taskRadGridView;
        
        internal Telerik.Windows.Controls.RadGridView productRequiredViewRadGridView;
        
        internal Telerik.Windows.Controls.RadGridView resultNoteRadGridView;
        
        internal System.Windows.Controls.DomainDataSource taskDomainDataSource;
        
        internal System.Windows.Controls.DomainDataSource resultNoteDomainDataSource;
        
        internal Telerik.Windows.Controls.RadTabItem WaterParameterRadTab;
        
        internal Telerik.Windows.Controls.RadGridView waterParameterLogRadGridView;
        
        internal System.Windows.Controls.DomainDataSource waterParameterLogDomainDataSource;
        
        internal Telerik.Windows.Controls.RadTabItem RequiredItemRadTabItem;
        
        internal System.Windows.Controls.DataGrid sumProductRequiredViewDataGrid;
        
        internal System.Windows.Controls.DataGridTemplateColumn dueDateColumn;
        
        internal System.Windows.Controls.DataGridTextColumn productIDColumn;
        
        internal System.Windows.Controls.DataGridTextColumn productNameColumn;
        
        internal System.Windows.Controls.DataGridTextColumn totalRequiredColumn;
        
        internal System.Windows.Controls.DomainDataSource sumProductRequiredViewDomainDataSource;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/PondStatus.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RadTabItem = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("RadTabItem")));
            this.pondRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("pondRadGridView")));
            this.pondDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondDomainDataSource")));
            this.pondsProductionCycleRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("pondsProductionCycleRadGridView")));
            this.pondsProductionCycleDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondsProductionCycleDomainDataSource")));
            this.pondStatusRadTabItem = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("pondStatusRadTabItem")));
            this.taskRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("taskRadGridView")));
            this.productRequiredViewRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("productRequiredViewRadGridView")));
            this.resultNoteRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("resultNoteRadGridView")));
            this.taskDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("taskDomainDataSource")));
            this.resultNoteDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("resultNoteDomainDataSource")));
            this.WaterParameterRadTab = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("WaterParameterRadTab")));
            this.waterParameterLogRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("waterParameterLogRadGridView")));
            this.waterParameterLogDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("waterParameterLogDomainDataSource")));
            this.RequiredItemRadTabItem = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("RequiredItemRadTabItem")));
            this.sumProductRequiredViewDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("sumProductRequiredViewDataGrid")));
            this.dueDateColumn = ((System.Windows.Controls.DataGridTemplateColumn)(this.FindName("dueDateColumn")));
            this.productIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("productIDColumn")));
            this.productNameColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("productNameColumn")));
            this.totalRequiredColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("totalRequiredColumn")));
            this.sumProductRequiredViewDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("sumProductRequiredViewDomainDataSource")));
        }
    }
}

