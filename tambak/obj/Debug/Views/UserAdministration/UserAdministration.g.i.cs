﻿#pragma checksum "C:\Users\fredy\Desktop\Tambak2\Tambak\branches\NewFix\new\tambak\Views\UserAdministration\UserAdministration.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B6733E5D87A3C323E49856B680C67A7"
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


namespace tambak.Views.UserAdministration {
    
    
    public partial class UserAdministration : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadGridView UserRadGridView;
        
        internal Telerik.Windows.Controls.RadGridView RolesRadGridView;
        
        internal System.Windows.Controls.TextBox RoleNameTextBox;
        
        internal System.Windows.Controls.Button addNewRoleButton;
        
        internal System.Windows.Controls.TextBox selectedRolesTextbox;
        
        internal System.Windows.Controls.TextBox SelectedUserTextBox;
        
        internal System.Windows.Controls.Button AssignRoleButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/UserAdministration/UserAdministration.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.UserRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("UserRadGridView")));
            this.RolesRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("RolesRadGridView")));
            this.RoleNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("RoleNameTextBox")));
            this.addNewRoleButton = ((System.Windows.Controls.Button)(this.FindName("addNewRoleButton")));
            this.selectedRolesTextbox = ((System.Windows.Controls.TextBox)(this.FindName("selectedRolesTextbox")));
            this.SelectedUserTextBox = ((System.Windows.Controls.TextBox)(this.FindName("SelectedUserTextBox")));
            this.AssignRoleButton = ((System.Windows.Controls.Button)(this.FindName("AssignRoleButton")));
        }
    }
}
