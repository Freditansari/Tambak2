﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak\branches\NewFix\new\tambak\Views\TasksView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1DB2BB6C87B507D01AD8D31BBF9CEED4"
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
    
    
    public partial class TasksView : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadTabItem RadTabItem;
        
        internal System.Windows.Controls.DomainDataSource contactDomainDataSource;
        
        internal Telerik.Windows.Controls.RadGridView contactRadGridView;
        
        internal System.Windows.Controls.Grid grid4;
        
        internal System.Windows.Controls.TextBox contactIDTextBox;
        
        internal Telerik.Windows.Controls.RadTabItem ManageTaskRadTabItem;
        
        internal System.Windows.Controls.DomainDataSource taskDomainDataSource;
        
        internal Telerik.Windows.Controls.RadGridView taskRadGridView;
        
        internal System.Windows.Controls.Grid grid2;
        
        internal System.Windows.Controls.TextBox attachmentsTextBox1;
        
        internal System.Windows.Controls.TextBox completePercentageTextBox1;
        
        internal System.Windows.Controls.TextBox descriptionTextBox1;
        
        internal Telerik.Windows.Controls.RadDateTimePicker dueDateRadDateTimePicker1;
        
        internal Telerik.Windows.Controls.RadDateTimePicker endDateRadDateTimePicker1;
        
        internal System.Windows.Controls.TextBox pondIDTextBox1;
        
        internal System.Windows.Controls.TextBox priorityTextBox1;
        
        internal System.Windows.Controls.TextBox productionCycleIDTextBox1;
        
        internal System.Windows.Controls.TextBox reccurencePatternTextBox1;
        
        internal Telerik.Windows.Controls.RadDateTimePicker startDateRadDateTimePicker1;
        
        internal System.Windows.Controls.TextBox statusTextBox1;
        
        internal System.Windows.Controls.TextBox taskIDTextBox1;
        
        internal System.Windows.Controls.TextBox titleTextBox1;
        
        internal System.Windows.Controls.TextBox userIdTextBox1;
        
        internal System.Windows.Controls.TextBox assignedToTextBox1;
        
        internal System.Windows.Controls.CheckBox isDoneCheckBox1;
        
        internal System.Windows.Controls.TextBox plannedManHoursTextBox1;
        
        internal System.Windows.Controls.DomainDataSource resultNoteDomainDataSource;
        
        internal System.Windows.Controls.Grid grid3;
        
        internal System.Windows.Controls.TextBox userIdTextBox2;
        
        internal System.Windows.Controls.DatePicker entryDateDatePicker;
        
        internal System.Windows.Controls.TextBox resultIDTextBox;
        
        internal System.Windows.Controls.TextBox taskIDTextBox2;
        
        internal System.Windows.Controls.TextBox resultNote1TextBox;
        
        internal System.Windows.Controls.Button SaveButton;
        
        internal System.Windows.Controls.Button addResultsButton;
        
        internal Telerik.Windows.Controls.RadTabItem newTaskRadTabItem;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox attachmentsTextBox;
        
        internal System.Windows.Controls.TextBox completePercentageTextBox;
        
        internal System.Windows.Controls.TextBox descriptionTextBox;
        
        internal Telerik.Windows.Controls.RadDateTimePicker dueDateRadDateTimePicker;
        
        internal Telerik.Windows.Controls.RadDateTimePicker endDateRadDateTimePicker;
        
        internal System.Windows.Controls.TextBox pondIDTextBox;
        
        internal System.Windows.Controls.TextBox priorityTextBox;
        
        internal System.Windows.Controls.TextBox productionCycleIDTextBox;
        
        internal System.Windows.Controls.TextBox reccurencePatternTextBox;
        
        internal Telerik.Windows.Controls.RadDateTimePicker startDateRadDateTimePicker;
        
        internal System.Windows.Controls.TextBox statusTextBox;
        
        internal System.Windows.Controls.TextBox taskIDTextBox;
        
        internal System.Windows.Controls.TextBox titleTextBox;
        
        internal System.Windows.Controls.TextBox userIdTextBox;
        
        internal System.Windows.Controls.TextBox assignedToTextBox;
        
        internal System.Windows.Controls.CheckBox isDoneCheckBox;
        
        internal System.Windows.Controls.TextBox plannedManHoursTextBox;
        
        internal System.Windows.Controls.Button SaveNewTaskButton;
        
        internal System.Windows.Controls.DomainDataSource pondDomainDataSource;
        
        internal Telerik.Windows.Controls.RadGridView pondRadGridView;
        
        internal System.Windows.Controls.Grid grid5;
        
        internal System.Windows.Controls.TextBox pondIDTextBox2;
        
        internal System.Windows.Controls.DomainDataSource pondsProductionCycleDomainDataSource;
        
        internal Telerik.Windows.Controls.RadGridView pondsProductionCycleRadGridView;
        
        internal Telerik.Windows.Controls.RadTabItem requiredProductRadTabItem;
        
        internal System.Windows.Controls.DomainDataSource productRequiredDomainDataSource;
        
        internal System.Windows.Controls.Grid grid6;
        
        internal System.Windows.Controls.TextBox amountTextBox;
        
        internal System.Windows.Controls.TextBox productIDTextBox;
        
        internal System.Windows.Controls.TextBox requirementIDTextBox;
        
        internal System.Windows.Controls.TextBox taskIDTextBox3;
        
        internal Telerik.Windows.Controls.RadGridView productRadGridView;
        
        internal System.Windows.Controls.DomainDataSource productDomainDataSource;
        
        internal System.Windows.Controls.Button SaveRequiredProductButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/TasksView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RadTabItem = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("RadTabItem")));
            this.contactDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("contactDomainDataSource")));
            this.contactRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("contactRadGridView")));
            this.grid4 = ((System.Windows.Controls.Grid)(this.FindName("grid4")));
            this.contactIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("contactIDTextBox")));
            this.ManageTaskRadTabItem = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("ManageTaskRadTabItem")));
            this.taskDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("taskDomainDataSource")));
            this.taskRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("taskRadGridView")));
            this.grid2 = ((System.Windows.Controls.Grid)(this.FindName("grid2")));
            this.attachmentsTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("attachmentsTextBox1")));
            this.completePercentageTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("completePercentageTextBox1")));
            this.descriptionTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("descriptionTextBox1")));
            this.dueDateRadDateTimePicker1 = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("dueDateRadDateTimePicker1")));
            this.endDateRadDateTimePicker1 = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("endDateRadDateTimePicker1")));
            this.pondIDTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("pondIDTextBox1")));
            this.priorityTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("priorityTextBox1")));
            this.productionCycleIDTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("productionCycleIDTextBox1")));
            this.reccurencePatternTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("reccurencePatternTextBox1")));
            this.startDateRadDateTimePicker1 = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("startDateRadDateTimePicker1")));
            this.statusTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("statusTextBox1")));
            this.taskIDTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("taskIDTextBox1")));
            this.titleTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("titleTextBox1")));
            this.userIdTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("userIdTextBox1")));
            this.assignedToTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("assignedToTextBox1")));
            this.isDoneCheckBox1 = ((System.Windows.Controls.CheckBox)(this.FindName("isDoneCheckBox1")));
            this.plannedManHoursTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("plannedManHoursTextBox1")));
            this.resultNoteDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("resultNoteDomainDataSource")));
            this.grid3 = ((System.Windows.Controls.Grid)(this.FindName("grid3")));
            this.userIdTextBox2 = ((System.Windows.Controls.TextBox)(this.FindName("userIdTextBox2")));
            this.entryDateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("entryDateDatePicker")));
            this.resultIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("resultIDTextBox")));
            this.taskIDTextBox2 = ((System.Windows.Controls.TextBox)(this.FindName("taskIDTextBox2")));
            this.resultNote1TextBox = ((System.Windows.Controls.TextBox)(this.FindName("resultNote1TextBox")));
            this.SaveButton = ((System.Windows.Controls.Button)(this.FindName("SaveButton")));
            this.addResultsButton = ((System.Windows.Controls.Button)(this.FindName("addResultsButton")));
            this.newTaskRadTabItem = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("newTaskRadTabItem")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.attachmentsTextBox = ((System.Windows.Controls.TextBox)(this.FindName("attachmentsTextBox")));
            this.completePercentageTextBox = ((System.Windows.Controls.TextBox)(this.FindName("completePercentageTextBox")));
            this.descriptionTextBox = ((System.Windows.Controls.TextBox)(this.FindName("descriptionTextBox")));
            this.dueDateRadDateTimePicker = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("dueDateRadDateTimePicker")));
            this.endDateRadDateTimePicker = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("endDateRadDateTimePicker")));
            this.pondIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pondIDTextBox")));
            this.priorityTextBox = ((System.Windows.Controls.TextBox)(this.FindName("priorityTextBox")));
            this.productionCycleIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productionCycleIDTextBox")));
            this.reccurencePatternTextBox = ((System.Windows.Controls.TextBox)(this.FindName("reccurencePatternTextBox")));
            this.startDateRadDateTimePicker = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("startDateRadDateTimePicker")));
            this.statusTextBox = ((System.Windows.Controls.TextBox)(this.FindName("statusTextBox")));
            this.taskIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taskIDTextBox")));
            this.titleTextBox = ((System.Windows.Controls.TextBox)(this.FindName("titleTextBox")));
            this.userIdTextBox = ((System.Windows.Controls.TextBox)(this.FindName("userIdTextBox")));
            this.assignedToTextBox = ((System.Windows.Controls.TextBox)(this.FindName("assignedToTextBox")));
            this.isDoneCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("isDoneCheckBox")));
            this.plannedManHoursTextBox = ((System.Windows.Controls.TextBox)(this.FindName("plannedManHoursTextBox")));
            this.SaveNewTaskButton = ((System.Windows.Controls.Button)(this.FindName("SaveNewTaskButton")));
            this.pondDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondDomainDataSource")));
            this.pondRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("pondRadGridView")));
            this.grid5 = ((System.Windows.Controls.Grid)(this.FindName("grid5")));
            this.pondIDTextBox2 = ((System.Windows.Controls.TextBox)(this.FindName("pondIDTextBox2")));
            this.pondsProductionCycleDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondsProductionCycleDomainDataSource")));
            this.pondsProductionCycleRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("pondsProductionCycleRadGridView")));
            this.requiredProductRadTabItem = ((Telerik.Windows.Controls.RadTabItem)(this.FindName("requiredProductRadTabItem")));
            this.productRequiredDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("productRequiredDomainDataSource")));
            this.grid6 = ((System.Windows.Controls.Grid)(this.FindName("grid6")));
            this.amountTextBox = ((System.Windows.Controls.TextBox)(this.FindName("amountTextBox")));
            this.productIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productIDTextBox")));
            this.requirementIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("requirementIDTextBox")));
            this.taskIDTextBox3 = ((System.Windows.Controls.TextBox)(this.FindName("taskIDTextBox3")));
            this.productRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("productRadGridView")));
            this.productDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("productDomainDataSource")));
            this.SaveRequiredProductButton = ((System.Windows.Controls.Button)(this.FindName("SaveRequiredProductButton")));
        }
    }
}

