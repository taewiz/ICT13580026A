using System;

using Xamarin.Forms;

namespace ICT13580026A
{
    public class NavPage2 : ContentPage
    {
        public NavPage2()
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

