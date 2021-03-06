﻿#pragma checksum "..\..\..\..\MainApp\Order\DisplayOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "992DE673F45F71E31CDA9445513495EF00947196533849AB241877723FDE7541"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ECommerce_GUI.MainApp.Order;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace ECommerce_GUI.MainApp.Order {
    
    
    /// <summary>
    /// DisplayOrder
    /// </summary>
    public partial class DisplayOrder : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock orderIDText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock deliveryText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock expectedShipTime;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalText;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button receive;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button detail;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
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
            System.Uri resourceLocater = new System.Uri("/ECommerce_GUI;component/mainapp/order/displayorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
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
            this.orderIDText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.deliveryText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.expectedShipTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.totalText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.receive = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
            this.receive.Click += new System.Windows.RoutedEventHandler(this.receive_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.detail = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
            this.detail.Click += new System.Windows.RoutedEventHandler(this.detail_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\MainApp\Order\DisplayOrder.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

