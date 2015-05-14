// -----------------------------------------------------------------------
//  <copyright file="UserRepository.cs" company="Polaris Industries, Inc.">
//      © Polaris Industries, Inc. 2015
//  </copyright>
// -----------------------------------------------------------------------
using System;

// First arg: What are we rendering for?  Second arg: What class should do the rendering?
using Xamtastic.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Xamarin.Forms;
using Xamtastic;


[assembly: ExportRenderer(typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]
namespace Xamtastic.Droid
{
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        // Override the OnElementChanged method so we can tweak this renderer post-initial setup
        protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged (e);
            if (Control != null) 
            {   
                var offsetToUse = ((ExtendedButton)this.Element).ShadowOffset;

                Control.SetShadowLayer(2, offsetToUse, offsetToUse, Android.Graphics.Color.DarkGray);
            } 
        }
    }
}

