using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580026A
{
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()
        {
            InitializeComponent();
            backtButton.Clicked+= BacktButton_Clicked;
            backtToRootButton.Clicked+= BacktToRootButton_Clicked;
        }

        void BacktButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        void BacktToRootButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
