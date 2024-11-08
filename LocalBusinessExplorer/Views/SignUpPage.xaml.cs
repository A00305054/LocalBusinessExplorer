using Microsoft.Maui.Controls;

namespace LocalBusinessExplorer.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sign Up", "Sign up successful!", "OK");
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
