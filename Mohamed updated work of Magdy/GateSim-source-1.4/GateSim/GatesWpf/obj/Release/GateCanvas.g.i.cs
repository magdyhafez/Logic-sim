﻿#pragma checksum "..\..\GateCanvas.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5924AB25560499594027CE710839462D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GatesWpf;
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


namespace GatesWpf {
    
    
    /// <summary>
    /// GateCanvas
    /// </summary>
    public partial class GateCanvas : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\GateCanvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer GCScroller;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\GateCanvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas GC;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\GateCanvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle dragSelect;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\GateCanvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GatesWpf.Wire dragWire;
        
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
            System.Uri resourceLocater = new System.Uri("/GatesWpf;component/gatecanvas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GateCanvas.xaml"
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
            this.GCScroller = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 6 "..\..\GateCanvas.xaml"
            this.GCScroller.SizeChanged += new System.Windows.SizeChangedEventHandler(this.GCScroller_SizeChanged);
            
            #line default
            #line hidden
            
            #line 6 "..\..\GateCanvas.xaml"
            this.GCScroller.LayoutUpdated += new System.EventHandler(this.GCScroller_LayoutUpdated);
            
            #line default
            #line hidden
            
            #line 6 "..\..\GateCanvas.xaml"
            this.GCScroller.ScrollChanged += new System.Windows.Controls.ScrollChangedEventHandler(this.GCScroller_ScrollChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GC = ((System.Windows.Controls.Canvas)(target));
            
            #line 7 "..\..\GateCanvas.xaml"
            this.GC.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GateCanvas_MouseDown);
            
            #line default
            #line hidden
            
            #line 7 "..\..\GateCanvas.xaml"
            this.GC.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.GateCanvas_MouseUp);
            
            #line default
            #line hidden
            
            #line 7 "..\..\GateCanvas.xaml"
            this.GC.MouseMove += new System.Windows.Input.MouseEventHandler(this.GateCanvas_MouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dragSelect = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.dragWire = ((GatesWpf.Wire)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

