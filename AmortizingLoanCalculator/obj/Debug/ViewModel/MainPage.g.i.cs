#pragma checksum "..\..\..\ViewModel\MainPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8B15A7800DCDF487D29E84C7F275EDFDF29EB038"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AmortizingLoanCalculator.ViewModel;
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


namespace AmortizingLoanCalculator.ViewModel
{


    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AmortizingLoanCalculator;component/viewmodel/mainpage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\ViewModel\MainPage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button submit;
        internal System.Windows.Controls.TextBox initialPrincipalInput;
        internal System.Windows.Controls.TextBox textBox1;
        internal System.Windows.Controls.TextBox textBox2;
        internal System.Windows.Controls.TextBlock textBlock;
        internal System.Windows.Controls.TextBlock textBlock1;
        internal System.Windows.Controls.TextBlock textBlock2;
        internal System.Windows.Controls.TextBox textBox2_Copy;
        internal System.Windows.Controls.TextBlock textBlock2_Copy;
        internal System.Windows.Controls.TextBlock textBlock3;
    }
}

