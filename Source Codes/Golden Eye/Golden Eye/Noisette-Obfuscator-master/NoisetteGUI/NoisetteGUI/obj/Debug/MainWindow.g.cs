#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84FC94B797C701E2B199839B2D7794647915EB14"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NoisetteGUI;
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


namespace NoisetteGUI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 133 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rct_Grey;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rct_White;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse CloseButton;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse MaximizeButton;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path Trg_Red;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path Trg_White;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rct_transition;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Box_dropArea;
        
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
            System.Uri resourceLocater = new System.Uri("/NoisetteGUI;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Rct_Grey = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 133 "..\..\MainWindow.xaml"
            this.Rct_Grey.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DragTheForm);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Rct_White = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.CloseButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 145 "..\..\MainWindow.xaml"
            this.CloseButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ExitButton_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MinimizeButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 146 "..\..\MainWindow.xaml"
            this.MinimizeButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MaximizeButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 147 "..\..\MainWindow.xaml"
            this.MaximizeButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MaximizeButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Trg_Red = ((System.Windows.Shapes.Path)(target));
            return;
            case 7:
            this.Trg_White = ((System.Windows.Shapes.Path)(target));
            return;
            case 8:
            this.Rct_transition = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 189 "..\..\MainWindow.xaml"
            this.textBox.Drop += new System.Windows.DragEventHandler(this.textBox_Drop);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Box_dropArea = ((System.Windows.Controls.TextBox)(target));
            
            #line 190 "..\..\MainWindow.xaml"
            this.Box_dropArea.Drop += new System.Windows.DragEventHandler(this.textBox_Drop);
            
            #line default
            #line hidden
            
            #line 190 "..\..\MainWindow.xaml"
            this.Box_dropArea.PreviewDragEnter += new System.Windows.DragEventHandler(this.OnDragOver);
            
            #line default
            #line hidden
            
            #line 190 "..\..\MainWindow.xaml"
            this.Box_dropArea.PreviewDragOver += new System.Windows.DragEventHandler(this.OnDragOver);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

