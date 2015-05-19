// -----------------------------------------------------------------------
//  <copyright file="UserRepository.cs" company="Polaris Industries, Inc.">
//      © Polaris Industries, Inc. 2015
//  </copyright>
// -----------------------------------------------------------------------
using System;
using Xamarin.Forms.Platform.iOS;

using Xamarin.Forms;
using Xamtastic;
using Xamtastic.iOS;

// First arg: What are we rendering for?  Second arg: What class should do the rendering?
using UIKit;
using InfColorPickerBinding;

[assembly: ExportRenderer(typeof(ColorPickView), typeof(ColorPickViewRenderer))]
namespace Xamtastic.iOS
{
    public class ColorPickViewRenderer : ViewRenderer<ColorPickView, UIView>
    {
        InfColorPickerController viewController;

        ColorSelectedDelegate colorSelectedDelegate;

        protected override void OnElementChanged (ElementChangedEventArgs<ColorPickView> e)
        {
            base.OnElementChanged (e);
            if (Control == null) 
            {   
                this.viewController = InfColorPickerController.ColorPickerViewController;
                this.colorSelectedDelegate = new ColorSelectedDelegate (this.Element);
                this.viewController.Delegate = colorSelectedDelegate;

                this.SetNativeControl(this.viewController.View);
            } 

            // TODO: Is this needed?
            Control.Frame = this.Frame;
            Control.Bounds = this.Bounds;
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged (sender, e);

            if(e.PropertyName == "SourceColor")
            {
                this.viewController.SourceColor = ((ColorPickView)sender).SourceColor.ToUIColor();
            }
        }

        public class ColorSelectedDelegate:InfColorPickerControllerDelegate
        {
            ColorPickView colorPickView;

            public ColorSelectedDelegate(ColorPickView colorPickView)
            {
                this.colorPickView = colorPickView;
            }

            public override void ColorPickerControllerDidChangeColor(InfColorPickerController controller)
            {
                UIColor resultColor = controller.ResultColor;

                nfloat red, green, blue, alpha;
                resultColor.GetRGBA(out red, out green, out blue, out alpha);

                this.colorPickView.ResultColor = new Color(red, green, blue, alpha);
            }
        }
    }
}

