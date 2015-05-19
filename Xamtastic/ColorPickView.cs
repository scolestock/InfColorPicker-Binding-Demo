// -----------------------------------------------------------------------
//  <copyright file="UserRepository.cs" company="Polaris Industries, Inc.">
//      © Polaris Industries, Inc. 2015
//  </copyright>
// -----------------------------------------------------------------------
using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Xamtastic
{
    public class ColorPickView : ContentView, INotifyPropertyChanged
    {
//        public event PropertyChangedEventHandler PropertyChanged;
//
//        void OnPropertyChanged([CallerMemberName] string propertyName = null)
//        {
//            var handler = PropertyChanged;
//            if (handler != null)
//            {
//                handler(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }

        public static BindableProperty ResultColorProperty =
            BindableProperty.Create<ColorPickView, Color>(
                control => control.ResultColor,
                defaultValue: Color.White, 
                propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((ColorPickView)bindable).ResultColor = newValue;
            });

        public Color ResultColor
        {
            get
            {
                return (Color)GetValue(ResultColorProperty); 
            }
            set
            {
                this.SetValue(ResultColorProperty, value);
            }
        }

        public static BindableProperty SourceColorProperty =
            BindableProperty.Create<ColorPickView, Color>(
                control => control.SourceColor,
                defaultValue: default(Color));

        public Color SourceColor
        {
            get
            {
                return (Color)GetValue(SourceColorProperty); 
            }
            set
            {
                this.SetValue(SourceColorProperty, value);
            }
        }

        public ColorPickView ()
        {
        }
    }
}

