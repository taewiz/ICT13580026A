using Xamarin.Forms;

namespace ICT13580026A
{
    public partial class ICT13580026APage : ContentPage
    {
        public ICT13580026APage()
        {
            InitializeComponent();
            okButton.Clicked += OkButton_Clicked;
            genderPicker.Items.Add("Male");
            genderPicker.Items.Add("Female");
            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged+= MyStepper_ValueChanged;

        }

        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = lastNameEntry.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }


        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
			int value = (int)e.NewValue;
			valueLabel.Text = value.ToString();
        }
    }
}
