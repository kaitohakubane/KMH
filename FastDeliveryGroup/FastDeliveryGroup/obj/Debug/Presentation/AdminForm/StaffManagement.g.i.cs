﻿#pragma checksum "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0B998A321270B90D72D130F59BE2FD7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FastDeliveryGroup.Presentation.AdminForm;
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


namespace FastDeliveryGroup.Presentation.AdminForm {
    
    
    /// <summary>
    /// StaffManagement
    /// </summary>
    public partial class StaffManagement : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddStaff;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteStaff;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgStaff;
        
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
            System.Uri resourceLocater = new System.Uri("/FastDeliveryGroup;component/presentation/adminform/staffmanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml"
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
            
            #line 9 "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnAddStaff = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml"
            this.btnAddStaff.Click += new System.Windows.RoutedEventHandler(this.btnAddStaff_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDeleteStaff = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Presentation\AdminForm\StaffManagement.xaml"
            this.btnDeleteStaff.Click += new System.Windows.RoutedEventHandler(this.btnDeleteStaff_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtgStaff = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

