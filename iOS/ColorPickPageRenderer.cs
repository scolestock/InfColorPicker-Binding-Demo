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

using UIKit;
using InfColorPickerBinding;

// First arg: What are we rendering for?  Second arg: What class should do the rendering?
[assembly: ExportRenderer(typeof(ColorPickPage), typeof(ColorPickPageRenderer))]
namespace Xamtastic.iOS
{
    public class ColorPickPageRenderer : PageRenderer
    {
        ColorSelectedDelegate colorSelectedDelegate;
        protected override void OnElementChanged (VisualElementChangedEventArgs e)
        {
            base.OnElementChanged (e);

            var page = e.NewElement as ColorPickPage;

            InfColorPickerController picker = InfColorPickerController.ColorPickerViewController;

            this.colorSelectedDelegate = new ColorSelectedDelegate(page);
            picker.Delegate = colorSelectedDelegate;

            var hostViewController = ViewController;
            hostViewController.AddChildViewController (picker);
            hostViewController.View.Add (picker.View);

            picker.DidMoveToParentViewController (hostViewController);
        }

        public class ColorSelectedDelegate:InfColorPickerControllerDelegate
        {
            ColorPickPage page;

            public ColorSelectedDelegate(ColorPickPage page)
            {
                this.page = page;
            }

            public override void ColorPickerControllerDidChangeColor(InfColorPickerController controller)
            {
                UIColor resultColor = controller.ResultColor;

                nfloat red, green, blue, alpha;
                resultColor.GetRGBA(out red, out green, out blue, out alpha);

                this.page.ResultColor = new Color(red, green, blue, alpha);
            }
        }
    }
}

