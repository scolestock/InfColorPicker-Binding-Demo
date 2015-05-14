
using System;
using Xamtastic.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamtastic;


// First arg: What are we rendering for?  Second arg: What class should do the rendering?
[assembly: ExportRenderer(typeof(ExtendedButton), typeof(ExtendedButtonRenderer))]

namespace Xamtastic.iOS
{
    // Derive from an existing renderer if you're customizing an existing Xamarin Forms control
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        // Override the OnElementChanged method so we can tweak this renderer post-initial setup
        protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged (e);
            if (Control != null) 
            {   
                // perform initial setup
                Control.SetTitleShadowColor(UIColor.DarkGray, UIControlState.Normal);

                var offsetToUse = ((ExtendedButton)this.Element).ShadowOffset;

                Control.TitleShadowOffset = new CoreGraphics.CGSize(offsetToUse, offsetToUse);
            } 
        }


    }
}



