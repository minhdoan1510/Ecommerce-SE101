﻿#pragma checksum "..\..\..\..\MainApp\Product\DisplayProdudct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "82FA7CB9266896942D4C52331FA80A548C4C8C6DD16932B9E8DD382812896BED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ECommerce_GUI.MainApp.Product;
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


namespace ECommerce_GUI.MainApp.Product {
    
    
    /// <summary>
    /// DisplayProduct
    /// </summary>
    public partial class DisplayProduct : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\MainApp\Product\DisplayProdudct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush productMainUrl;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\MainApp\Product\DisplayProdudct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock productName;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\MainApp\Product\DisplayProdudct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock productPrice;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\MainApp\Product\DisplayProdudct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock productTotalSale;
        
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
            System.Uri resourceLocater = new System.Uri("/ECommerce_GUI;component/mainapp/product/displayprodudct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainApp\Product\DisplayProdudct.xaml"
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
            
            #line 12 "..\..\..\..\MainApp\Product\DisplayProdudct.xaml"
            ((ECommerce_GUI.MainApp.Product.DisplayProduct)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.productMainUrl = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 3:
            this.productName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.productPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.productTotalSale = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

