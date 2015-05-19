// -----------------------------------------------------------------------
//  <copyright file="UserRepository.cs" company="Polaris Industries, Inc.">
//      © Polaris Industries, Inc. 2015
//  </copyright>
// -----------------------------------------------------------------------
using System;

using Xamarin.Forms;
using System.Globalization;

namespace Xamtastic
{
    public class ColorToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color  = (Color)value;
            return string.Format("{0:F},{1:F},{2:F}", color.R, color.G, color.B);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string[] colors = ((string)value).Split(',');
                return new Color(System.Convert.ToDouble(colors[0]), System.Convert.ToDouble(colors[1]), System.Convert.ToDouble(colors[2]));
            }
            catch (Exception)
            {
                // Shhhh
                return Color.Default;
            }
        }
    }

    public class App : Application
    {
        public App ()
        {
            var colorPickView = new ColorPickView { HeightRequest = 400 };

            var resultColorLabel = new Label();
            resultColorLabel.SetBinding<ColorPickView>(Label.TextProperty, cp => cp.ResultColor, BindingMode.OneWay, converter:new ColorToStringConverter());
            resultColorLabel.BindingContext = colorPickView;

            var sourceColorEntry = new Entry {Placeholder = "R, G, B"};
            sourceColorEntry.SetBinding<ColorPickView>(Entry.TextProperty, cp => cp.SourceColor, BindingMode.OneWayToSource, converter:new ColorToStringConverter());
            sourceColorEntry.BindingContext = colorPickView;


            // The root page of your application
            MainPage = new NavigationPage(new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        resultColorLabel,
                        sourceColorEntry,
                        colorPickView
                    }
                }
            });

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }

}

