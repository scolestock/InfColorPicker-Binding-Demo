// -----------------------------------------------------------------------
//  <copyright file="UserRepository.cs" company="Polaris Industries, Inc.">
//      © Polaris Industries, Inc. 2015
//  </copyright>
// -----------------------------------------------------------------------
using System;
using Xamtastic.iOS;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using Xamtastic;

[assembly: ExportRenderer(typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]
namespace Xamtastic.iOS
{
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged (e);
            if (Control != null) 
            {   
                // "Control" is the iOS UIButton instance, at least in a ButtonRenderer-derived class
                Control.SetTitleShadowColor(UIColor.LightGray, UIControlState.Normal);

                var offset = ((ExtendedButton)this.Element).ShadowOffset;

                Control.TitleShadowOffset = new CoreGraphics.CGSize(offset, offset);
            } 
        }

    }
}

