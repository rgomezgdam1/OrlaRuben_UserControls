﻿#pragma checksum "..\..\Puesto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58AD2CE3BF50054FE2587EA3466F0E82659C9F92F7E56443048DCF4151817138"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using OrlaRuben;
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


namespace OrlaRuben {
    
    
    /// <summary>
    /// Puesto
    /// </summary>
    public partial class Puesto : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Puesto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OrlaRuben.Puesto root;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Puesto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LabelPuesto;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Puesto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Persona;
        
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
            System.Uri resourceLocater = new System.Uri("/OrlaRuben;component/puesto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Puesto.xaml"
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
            this.root = ((OrlaRuben.Puesto)(target));
            return;
            case 2:
            this.LabelPuesto = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Persona = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Puesto.xaml"
            this.Persona.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Persona_MouseEnter);
            
            #line default
            #line hidden
            
            #line 37 "..\..\Puesto.xaml"
            this.Persona.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Persona_MouseLeave);
            
            #line default
            #line hidden
            
            #line 38 "..\..\Puesto.xaml"
            this.Persona.Click += new System.Windows.RoutedEventHandler(this.Persona_Click);
            
            #line default
            #line hidden
            
            #line 39 "..\..\Puesto.xaml"
            this.Persona.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Persona_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

