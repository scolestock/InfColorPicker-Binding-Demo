// -----------------------------------------------------------------------
//  <copyright file="UserRepository.cs" company="Polaris Industries, Inc.">
//      © Polaris Industries, Inc. 2015
//  </copyright>
// -----------------------------------------------------------------------
using System;

using Xamarin.Forms;

namespace Xamtastic
{
    public class ColorPickPage : ContentPage
    {
        Color resultColor;

        public Color ResultColor
        {
            get
            {
                return resultColor;
            }

            set
            {
                this.resultColor = value;
                this.DisplayAlert("New Color", this.resultColor.ToString(), "OK");
            }
        }

        public ColorPickPage ()
        {
            Content = new StackLayout { 
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


