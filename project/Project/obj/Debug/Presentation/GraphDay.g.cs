﻿#pragma checksum "..\..\..\Presentation\GraphDay.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "31BC0668E61108C5CD814C5E78D5AA2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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


namespace Project.Presentation {
    
    
    /// <summary>
    /// GraphDay
    /// </summary>
    public partial class GraphDay : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Presentation\GraphDay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataVisualization.Charting.Chart ColumnChart1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Presentation\GraphDay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateEnd;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Presentation\GraphDay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnView;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Presentation\GraphDay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReportMonths;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Presentation\GraphDay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReportYear;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Presentation\GraphDay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDateStart;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Presentation\GraphDay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpYearChoose;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Presentation\GraphDay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/presentation/graphday.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Presentation\GraphDay.xaml"
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
            this.ColumnChart1 = ((System.Windows.Controls.DataVisualization.Charting.Chart)(target));
            return;
            case 2:
            this.dpDateEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.btnView = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Presentation\GraphDay.xaml"
            this.btnView.Click += new System.Windows.RoutedEventHandler(this.btnView_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnReportMonths = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Presentation\GraphDay.xaml"
            this.btnReportMonths.Click += new System.Windows.RoutedEventHandler(this.btnReportMonths_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnReportYear = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Presentation\GraphDay.xaml"
            this.btnReportYear.Click += new System.Windows.RoutedEventHandler(this.btnReportYear_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dpDateStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.dpYearChoose = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

