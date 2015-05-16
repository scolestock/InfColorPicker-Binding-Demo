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
            var button = new Button { Text = "Show ColorPick" };
            button.Clicked += (sender, e) => this.MainPage.Navigation.PushAsync(new ColorPickPage());

            // The root page of your application
            MainPage = new NavigationPage(new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!",
                        },
                        button
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

