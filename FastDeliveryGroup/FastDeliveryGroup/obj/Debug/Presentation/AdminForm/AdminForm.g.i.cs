﻿#pragma checksum "..\..\..\..\Presentation\AdminForm\AdminForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D81A08AE0B11A0C1723C1C282B2CF6FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FastDeliveryGroup.Presentation.AdminForm;
using FastDeliveryGroup.Presentation.StaffForm;
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
    /// AdminForm
    /// </summary>
    public partial class AdminForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\Presentation\AdminForm\AdminForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FastDeliveryGroup.Presentation.AdminForm.AdminForm frmAdmin;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Presentation\AdminForm\AdminForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbxTab;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Presentation\AdminForm\AdminForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlUserControl;
        
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
            System.Uri resourceLocater = new System.Uri("/FastDeliveryGroup;component/presentation/adminform/adminform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Presentation\AdminForm\AdminForm.xaml"
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
            this.frmAdmin = ((FastDeliveryGroup.Presentation.AdminForm.AdminForm)(target));
            return;
            case 2:
            
            #line 11 "..\..\..\..\Presentation\AdminForm\AdminForm.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbxTab = ((System.Windows.Controls.ListBox)(target));
            
            #line 12 "..\..\..\..\Presentation\AdminForm\AdminForm.xaml"
            this.lbxTab.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbxTab_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pnlUserControl = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

