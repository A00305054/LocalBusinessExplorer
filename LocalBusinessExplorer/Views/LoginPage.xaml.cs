using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace LocalBusinessExplorer.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Please enter both email and password.", "OK");
                return;
            }

            bool success = await LoginAsync(email, password);
            if (success)
            {
                await DisplayAlert("Success", "Login successful!", "OK");
                // Navigate to the main page or home page
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "Invalid email or password.", "OK");
            }
        }

        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            // Navigate to the sign-up page or implement sign-up logic
            await Navigation.PushAsync(new SignUpPage());
        }

        private async Task<bool> LoginAsync(string email, string password)
        {
            // Replace this with actual authentication logic (e.g., call Firebase Auth API)
            return email == "test@example.com" && password == "password"; // Temporary check for demo purposes
        }
    }
}
