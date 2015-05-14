// -----------------------------------------------------------------------
//  <copyright file="UserRepository.cs" company="Polaris Industries, Inc.">
//      © Polaris Industries, Inc. 2015
//  </copyright>
// -----------------------------------------------------------------------
using System;

using Xamarin.Forms;

namespace Xamtastic
{
    public class App : Application
    {
        public App ()
        {
            var button = new ExtendedButton
            {
                Text = "Test Button",
                TextColor = Color.Black,
                BorderWidth = 1,
                BorderRadius = 2,
                Image = "icon.png",
                ShadowOffset = 3
            };

            var button2 = new Button
            {
                Text = "Test Button2",
                TextColor = Color.Black,
                BorderWidth = 1,
                BorderRadius = 2,
                Image = "icon.png"
            };

            // The root page of your application
            MainPage = new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!",
                        },
                        button,
                        button2
                    }
                }
            };
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

    public class ExtendedButton : Button
    {
        public int ShadowOffset { get; set; }
    }
}

