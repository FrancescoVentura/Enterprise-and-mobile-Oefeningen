﻿#pragma checksum "C:\Users\Frank\documents\visual studio 2015\Projects\StarWarsUWP.App\StarWarsUWP.App\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "771DBB2CCF19B9D6BE17F224FA53B2FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarWarsUWP.App
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Square = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 2:
                {
                    this.EpisodeList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 34 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.EpisodeList).SelectionChanged += this.EpisodeList_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.overview = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    this.upButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 67 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.upButton).Click += this.upButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.downButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 68 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.downButton).Click += this.downButton_Click_1;
                    #line default
                }
                break;
            case 6:
                {
                    this.Rating = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
