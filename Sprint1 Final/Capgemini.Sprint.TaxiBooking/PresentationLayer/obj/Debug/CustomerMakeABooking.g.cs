#pragma checksum "..\..\CustomerMakeABooking.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1DC32D2B6330BB5C69142833BB28AF358FB8D6CCA68C85A518D3FE878EC5E7E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PresentationLayer;
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


namespace PresentationLayer {
    
    
    /// <summary>
    /// CustomerMakeABooking
    /// </summary>
    public partial class CustomerMakeABooking : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PresentationLayer.CustomerMakeABooking WindowBooking;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBook;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker TxtTripDate;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSourceAddress;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDestinationAddress;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EndTimeSelection;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StartTimeSelection;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFare;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\CustomerMakeABooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lbl_CustomerRegistered;
        
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
            System.Uri resourceLocater = new System.Uri("/PresentationLayer;component/customermakeabooking.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomerMakeABooking.xaml"
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
            this.WindowBooking = ((PresentationLayer.CustomerMakeABooking)(target));
            
            #line 8 "..\..\CustomerMakeABooking.xaml"
            this.WindowBooking.Loaded += new System.Windows.RoutedEventHandler(this.WindowBooking_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnBook = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\CustomerMakeABooking.xaml"
            this.BtnBook.Click += new System.Windows.RoutedEventHandler(this.BtnBook_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtTripDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.TxtSourceAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtDestinationAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.EndTimeSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\CustomerMakeABooking.xaml"
            this.EndTimeSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EndTimeSelection_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.StartTimeSelection = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.lblFare = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Lbl_CustomerRegistered = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

