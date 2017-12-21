using System; using System.Collections.Generic;  using Xamarin.Forms;  namespace ICT13580026A {
	public partial class MyPage3 : ContentPage
	{
		public MyPage3()
		{
			InitializeComponent();             backtButton.Clicked+= BacktButton_Clicked; 
		}

        void BacktButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }



    } }    