// -----------------------------------------------------------------------
//  <copyright file="UserRepository.cs" company="Polaris Industries, Inc.">
//      © Polaris Industries, Inc. 2015
//  </copyright>
// -----------------------------------------------------------------------
using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Xamtastic;
using Xamtastic.Droid;

[assembly: ExportRenderer(typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]
namespace Xamtastic.Droid
{
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged (e);
            if (Control != null) 
            {   
                var offset = ((ExtendedButton)this.Element).ShadowOffset;

                // Control property is the Android Button instance when deriving from ButtonRenderer
                Control.SetShadowLayer(2, offset, offset, Android.Graphics.Color.CadetBlue);
            } 
        }
    }
}

