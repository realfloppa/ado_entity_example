﻿#pragma checksum "..\..\UserControl2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3445E59CBA35CC93A2912AA6B6AE30A734F2AFF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp4;


namespace WpfApp4 {
    
    
    /// <summary>
    /// UserControl2
    /// </summary>
    public partial class UserControl2 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbx1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\UserControl2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button3;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp4;component/usercontrol2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControl2.xaml"
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
            this.btn2 = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\UserControl2.xaml"
            this.btn2.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtbx1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\UserControl2.xaml"
            this.txtbx1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtbx1_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\UserControl2.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn2_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button1 = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\UserControl2.xaml"
            this.button1.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn2_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 22 "..\..\UserControl2.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn2_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 26 "..\..\UserControl2.xaml"
            ((System.Windows.Controls.Button)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.button2 = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\UserControl2.xaml"
            this.button2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 28 "..\..\UserControl2.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 32 "..\..\UserControl2.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Button_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 32 "..\..\UserControl2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 10:
            this.button3 = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\UserControl2.xaml"
            this.button3.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Button_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 34 "..\..\UserControl2.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Button_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

