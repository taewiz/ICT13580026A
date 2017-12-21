using System; using System.Collections.Generic;  using Xamarin.Forms;  namespace ICT13580026A {
    public partial class MyPage2 : ContentPage
    {
        public MyPage2()
        {
            InitializeComponent();
            nextButton.Clicked += NextButton_Clicked;             backtButton.Clicked += BacktButton_Clicked;
        }


        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage3());
        }


        void BacktButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }     } }  