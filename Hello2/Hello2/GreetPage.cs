using System;

using Xamarin.Forms;

namespace Hello2
{
    public class GreetPage : ContentPage
    {
        public GreetPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

