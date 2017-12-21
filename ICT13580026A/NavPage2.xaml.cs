using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580026A
{
    public partial class NavPage2 : ContentPage
    {
        public NavPage2()
        {
            InitializeComponent();
            nextButton.Clicked+= NextButton_Clicked;
            backtButton.Clicked+= BacktButton_Clicked;
        }

        void BacktButton_Clicked(object sender, EventArgs e)
        {
           Navigation.PopAsync();
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
			Navigation.PushAsync(new NavPage3());
        }
    }
}
