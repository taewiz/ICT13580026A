using System;

using Xamarin.Forms;

namespace ICT13580026A
{
    public class NavPage3 : ContentPage
    {
        public NavPage3()
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

